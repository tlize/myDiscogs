using myDiscogs.DiscogsApi;
using myDiscogs.Models.Inventory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.WebPages;

namespace myDiscogs.Controllers
{
    public class SalesController : Controller
    {
        private DiscogsClient client = new DiscogsClient();
        // GET: Sales
        public ActionResult Index()
        {
            int page = (Request.QueryString["page"] != null && Request.QueryString["page"] != string.Empty) ? Request.QueryString["page"].AsInt() : 1;

            var itemsforSaleData = client.GetItemsForSale(page);
            var itemsforSale = JsonConvert.DeserializeObject<PaginatedItems>(itemsforSaleData);

            return View(itemsforSale);
        }
    }
}