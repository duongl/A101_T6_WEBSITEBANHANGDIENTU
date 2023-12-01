using ShopBanLaptop2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Mime;
using System.Reflection.Metadata;
using Microsoft.AspNetCore.Http;
using System.Numerics;
namespace ShopBanLaptop2.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IHttpContextAccessor ctx;
        public ShoppingCartController(IHttpContextAccessor ctx)
        {
            this.ctx = ctx;
        }
        // GET: ShoppingCart
        public ActionResult showShopCart()
        {
            ViewBag.totalPrice = tinhTongTien();
            ViewBag.sl = tinhSoLuong();
            return View();
        }
        public ActionResult delete(int id)
        {
            var shopCart = JsonConvert.DeserializeObject<List<SCartInfo>>(ctx.HttpContext.Session.GetString("shopCart"));
            shopCart.Remove(shopCart.Where(r => r.lap.Id == id).FirstOrDefault());
            ctx.HttpContext.Session.SetString("shopCart", JsonConvert.SerializeObject(shopCart));
            return RedirectToAction("showShopCart");
        }

        public ActionResult addItem(int id)
        {
            var shopCart = JsonConvert.DeserializeObject<List<SCartInfo>>(ctx.HttpContext.Session.GetString("shopCart"));
            shopCart.Where(r => r.lap.Id == id).FirstOrDefault().soLuong++;
            ctx.HttpContext.Session.SetString("shopCart", JsonConvert.SerializeObject(shopCart));
            return RedirectToAction("showShopCart");
        }

        public ActionResult minusItem(int id)
        {
            var shopCart = JsonConvert.DeserializeObject<List<SCartInfo>>(ctx.HttpContext.Session.GetString("shopCart"));
            shopCart.Where(r => r.lap.Id == id).FirstOrDefault().soLuong--;
            if (shopCart.Where(r => r.lap.Id == id).FirstOrDefault().soLuong == 0)
                shopCart.Remove(shopCart.Where(r => r.lap.Id == id).FirstOrDefault());
            ctx.HttpContext.Session.SetString("shopCart", JsonConvert.SerializeObject(shopCart));
            return RedirectToAction("showShopCart");
        }

        public ActionResult setNullForShopCart()
        {
            ctx.HttpContext.Session.SetString("shopCart","");
            return RedirectToAction("showShopCart");
        }

        public double tinhTongTien()
        {
            double tongTien = 0;
            var shopCart = JsonConvert.DeserializeObject<List<SCartInfo>>(ctx.HttpContext.Session.GetString("shopCart")??"");
            if (shopCart == null) {
                return 0;
            }
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
            var shopCart = JsonConvert.DeserializeObject<List<SCartInfo>>(ctx.HttpContext.Session.GetString("shopCart")??"");
            if (shopCart == null)
            {
                return 0;
            }
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
            var user = JsonConvert.DeserializeObject<Account>(ctx.HttpContext.Session.GetString("account")??"");
            if (user == null) {
                return RedirectToAction("/"); ;
            }
            int idAccount = user.id;
            int status = 0;
            int kq = BillConnect.Instance.createBill(idAccount, status);
            if(kq > 0)
            {
                int _idBill  = BillConnect.Instance.getIdNoPay(idAccount);
                var shopCart = JsonConvert.DeserializeObject<List<SCartInfo>>(ctx.HttpContext.Session.GetString("shopCart"));
                foreach (var item in shopCart)
                {
                    BillInfoConnect.Instance.createBillInfo(_idBill, item.lap.Id, item.soLuong);
                }
                ViewBag.success =  BillConnect.Instance.setIsPay(idAccount);
            }
            setNullForShopCart();
           return  RedirectToAction("showShopCart") ;
           

        }

        public ActionResult downloadBill(int id)
        {
            var bill = BillConnect.Instance.getBillById(id);
            var obj = BillInfoToShowConnect.Instance.getBillInfoByIdBill(id);
            var user = JsonConvert.DeserializeObject<Account>(ctx.HttpContext.Session.GetString("account") ?? "");
            //var htmlContent = String.Format("<body>Hello world: {0}</body>", DateTime.Now);
            var htmlContent = @"
<!DOCTYPE html>
<html>
<head>
<meta http-equiv=""content-type"" content=""text/html; charset=utf-8"" />
<style>
html{
font-size: 20px;
}
table {
  font-family: arial, sans-serif;
  border-collapse: collapse;
  width: 100%;
}

td, th {
  border: 1px solid #dddddd;
  text-align: left;
  padding: 8px;
}

tr:nth-child(even) {
  background-color: #dddddd;
}
</style>
</head>
<body>
<h1>Laptop Shop</h1>
<h2>Thông tin hóa đơn</h2>
<h2>Khách hàng: ";
            htmlContent += user.displayName;
            htmlContent+= @"</h2>
<table>
  <tr>
<th>STT</th>
    <th>Tên sản phẩm</th>
    <th>Đơn giá</th>
    <th>Số lượng</th>
<th>Thành tiền</th>
  </tr>";

           
            int k = 1;
            double total = 0;
            foreach (var item in obj)
            {
                htmlContent+= String.Format(@"<tr>
<td>{0}</td>
    <td>{1}</td>
    <td>{2}</td>
    <td>{3}</td>
  <td>{4}</td>
  </tr>", k,item.Name,item.Price.ToString("#,###"), item.count,(item.Price*item.count).ToString("#,###"));
                k++;
                total += item.Price * item.count;
            }
            htmlContent += String.Format(@"</table>
<h2>Tổng tiền: {0} VND</h2>
<h2>Ngày tạo: {1}</h2>
</body></html>", total.ToString("#,###"), bill.datebuy);
            var pdfBytes = (new NReco.PdfGenerator.HtmlToPdfConverter()).GeneratePdf(htmlContent);
            var cd = new System.Net.Mime.ContentDisposition
            {
                // for example foo.bak
                FileName = "Bill_"+id+".pdf",

                // always prompt the user for downloading, set to true if you want 
                // the browser to try to show the file inline
                Inline = false,
            };
            Response.Headers["Content-Disposition"] = cd.ToString();
            return File(pdfBytes, MediaTypeNames.Text.RichText);

        }
    }
}