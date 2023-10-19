using ShopBanLaptop2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopBanLaptop2.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        public ActionResult showShopCart()
        {
            ViewBag.totalPrice = tinhTongTien();
            ViewBag.sl = tinhSoLuong();
            return View();
        }
        public ActionResult delete(int id)
        {
            var shopCart = Session["shopCart"] as List<SCartInfo>;
            shopCart.Remove(shopCart.Where(r => r.lap.Id == id).FirstOrDefault());
            return RedirectToAction("showShopCart");
        }

        public ActionResult addItem(int id)
        {
            var shopCart = Session["shopCart"] as List<SCartInfo>;
            shopCart.Where(r => r.lap.Id == id).FirstOrDefault().soLuong++;
            return RedirectToAction("showShopCart");
        }

        public ActionResult minusItem(int id)
        {
            var shopCart = Session["shopCart"] as List<SCartInfo>;
            shopCart.Where(r => r.lap.Id == id).FirstOrDefault().soLuong--;
            if (shopCart.Where(r => r.lap.Id == id).FirstOrDefault().soLuong == 0)
                shopCart.Remove(shopCart.Where(r => r.lap.Id == id).FirstOrDefault());
            return RedirectToAction("showShopCart");
        }

        public ActionResult setNullForShopCart()
        {
            Session["shopCart"] = null;
            return RedirectToAction("showShopCart");
        }

        public double tinhTongTien()
        {
            double tongTien = 0;
            var shopCart = Session["shopCart"] as List<SCartInfo>;
            if(shopCart != null)
            {
                foreach (var item in shopCart)
                {
                    tongTien += item.lap.Price * item.soLuong;
                }
            }
            return tongTien;
        }

        public int tinhSoLuong()
        {
            int soLuong = 0;
            var shopCart = Session["shopCart"] as List<SCartInfo>;
            if (shopCart != null)
            {
                foreach (var item in shopCart)
                {
                    soLuong += item.soLuong;
                }
            }
            return soLuong;
        }

        public ActionResult thanhToan()
        {
            var user = Session["account"] as Account;
            int idAccount = user.id;
            int status = 0;
            int kq = BillConnect.Instance.createBill(idAccount, status);
            if(kq > 0)
            {
                int _idBill  = BillConnect.Instance.getIdNoPay(idAccount);
                var shopCart = Session["shopCart"] as List<SCartInfo>;
                foreach (var item in shopCart)
                {
                    BillInfoConnect.Instance.createBillInfo(_idBill, item.lap.Id, item.soLuong);
                }
                ViewBag.success =  BillConnect.Instance.setIsPay(idAccount);
            }
            setNullForShopCart();
            return RedirectToAction("showShopCart");
        }
    }
}