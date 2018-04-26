using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestTaskShops.Models;

namespace TestTaskShops.Controllers
{
    public class HomeController : Controller
    {
        ShopContext db = new ShopContext();

        public ActionResult Index()
        {
                return View(db.Shops);
        }

        public ActionResult Goodsofshop(string s_name )
        {
            return View(db.Goods.Where( p =>p.shop_name == s_name));
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}