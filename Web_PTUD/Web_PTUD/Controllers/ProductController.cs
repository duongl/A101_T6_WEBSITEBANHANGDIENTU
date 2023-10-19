using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using ShopBanLaptop2.Models;

namespace ShopBanLaptop2.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            Laptop obj = LaptopConnect.Instance.getData().Where(x => x.Id == id).FirstOrDefault();
            
            return View(obj);
        }

        public ActionResult ShowAllLaptop()
        {
            var obj = LaptopConnect.Instance.getData();
            return View(obj);
        }

        public List<Laptop> setUp(List<Laptop> obj,  int? page)
        {
            int pg = 0;
            if (obj == null)
                return obj;
            if (page != null)
                pg = Convert.ToInt32(page);
            else
            {
                obj = obj.GetRange(pg * 20, (pg+1) * 20);
            }
            return obj;
        }

        public ActionResult Search(string txt_search)
        {
            List<Laptop> obj = new List<Laptop>();
            if (!string.IsNullOrEmpty(txt_search))
            {
                obj = LaptopConnect.Instance.search(txt_search);
            }
            else
            {
                obj = LaptopConnect.Instance.getData().ToList();
            }
            return View(obj);
        }

        public ActionResult sortByprice()
        {
            var laptops = LaptopConnect.Instance.getData().OrderBy(x => x.Price).ToList();
            return View(laptops);
        }


        [HttpGet]
        public ActionResult AddLaptop()
        {
            ViewBag.Success = 0;
            return View();
        }
        [HttpPost]
        public ActionResult AddLaptop(Laptop lap)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Success = LaptopConnect.Instance.addLaptop(lap.Name, lap.IdCategory, lap.Price, lap.ProductCompany, lap.monitor, lap.CPU, lap.RAM, lap.Image, lap.GPU, lap.HardDisk);
            }
            return View();
        }

        public ActionResult xoaLoaiSanPhan(int id)
        {
            if (LaptopConnect.Instance.Deletelaptop(id) >= 0)
            {
                return RedirectToAction("Search");
            }
            return RedirectToAction("Search");
        }
        [HttpGet]
        public ActionResult suaThongTinLaptop(int id)
        {
            Laptop obj = LaptopConnect.Instance.getData().Where(x => x.Id == id).FirstOrDefault();
            return View(obj);
        }
        [HttpPost]
        public ActionResult suaThongTinLaptop(Laptop lap)
        {
            if(ModelState.IsValid)
            {
                ViewBag.Success = LaptopConnect.Instance.EditLaptop(lap.Id, lap.Name, lap.IdCategory, lap.Price, lap.ProductCompany, lap.monitor, lap.CPU, lap.RAM, lap.Image, lap.GPU, lap.HardDisk);
                lap = LaptopConnect.Instance.getData().Where(x => x.Id == lap.Id).FirstOrDefault();
            }
            return View(lap);
        }


        //===========================
        public ActionResult accountInfo(int id)
        {
            return RedirectToAction("accountInfo", "Login", id);
        }

        public RedirectResult addShopCart(int id, int quatity)
        {
            var shopCart = new List<SCartInfo>();
            
            if (Session["shopCart"] != null)
            {
                shopCart = Session["shopCart"] as List<SCartInfo>;
            }
            if(shopCart.Where(r => r.lap.Id == id).FirstOrDefault() != null)
            {
                shopCart.Where(r => r.lap.Id == id).FirstOrDefault().soLuong++;
            }
            else
            {
                var lap = LaptopConnect.Instance.searchById(id).FirstOrDefault();
                SCartInfo laps = new SCartInfo(lap, quatity);
                shopCart.Add(laps);
            }

            Session["shopCart"] = shopCart;
            return Redirect("/Product/Details/" +id);
        }

        public ActionResult searchByPC(string productCompany)
        {
            var obj = LaptopConnect.Instance.searchByPC(productCompany).ToList();
            return View(obj);
        }

        public ActionResult searchByPrice(int price)
        {
            var obj = LaptopConnect.Instance.searchByPrice(price).ToList();
            return View(obj);
        }

        public ActionResult thanhToan(int idLap)
        {
            var user = Session["account"] as Account;
            int idAccount = user.id;
            int status = 0;
            int kq = BillConnect.Instance.createBill(idAccount, status);
            if (kq > 0)
            {
                int _idBill = BillConnect.Instance.getIdNoPay(idAccount);
                BillInfoConnect.Instance.createBillInfo(_idBill, idLap, 1);
                ViewBag.success =  BillConnect.Instance.setIsPay(idAccount);
            }
            return RedirectToAction("showShopCart");
        }
    }
}