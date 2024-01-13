using myDiscogs.DiscogsApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myDiscogs.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var client = new DiscogsClient();
            var value = client.GetCollectionValueAsync();
            //var collection = client.GetCollectionAsync();
            //var inventory = client.GetInventoryAsync();
            //var wantlist = client.GetWantListAsync();
            //var orders = client.GetOrdersAsync();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}