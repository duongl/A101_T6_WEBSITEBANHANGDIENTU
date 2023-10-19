using ShopBanLaptop2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopBanLaptop2.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string userName, string password)
        {
            var obj = AccountConnect.Instance.login(userName, password).FirstOrDefault();
            if ( obj != null)
            {
                Session["login"] = 1;
                Session["account"] = new Account()
                {
                    id = obj.id,
                    displayName = obj.displayName,
                    userName = obj.userName,
                    password = obj.password,
                    type = obj.type,
                };
                return RedirectToAction("search", "Product");
            }
            return View();
        }

        
       public ActionResult logOut()
        {
            Session["account"] = null;
            return RedirectToAction("search", "Product");
        }


        public ActionResult accountInfo(int id)
        {
            var obj = AccountConnect.Instance.getData().Where(x => x.id == id).FirstOrDefault();
            return View(obj);
        }

        public ActionResult getBillsByAccount(int id)
        {
            var obj = BillConnect.Instance.getBillsByAccount(id);
            return View(obj);
        }

        public ActionResult billInfos(int id)
        {
            var obj = BillInfoToShowConnect.Instance.getBillInfoByIdBill(id);
            return View(obj);
        }
        [HttpGet]
        public ActionResult createAccount()
        {
            ViewBag.kq  = 0;
            return View();
        }

        [HttpPost]
        public ActionResult createAccount(Account acc)
        {
            ViewBag.kq  = 0;
            if (ModelState.IsValid)
            {
                ViewBag.kq = AccountConnect.Instance.addAccount(acc.userName, acc.password);
                if(ViewBag.kq >= 1)
                return RedirectToAction("Login", "Login");
            }
            return View();
        }


        [HttpGet]
        public ActionResult edit(int id)
        {
            Account obj = AccountConnect.Instance.getData().Where(x => x.id == id).FirstOrDefault();
            return View(obj);
        }
        [HttpPost]
        public ActionResult edit(Account acc)
        {
            ViewBag.Success = AccountConnect.Instance.editAccount(acc.id, acc.displayName, acc.password);
            Account obj = AccountConnect.Instance.getData().Where(x => x.id == acc.id).FirstOrDefault();
            return View(obj);
        }
    }
}