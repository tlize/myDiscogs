using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using myDiscogs.Data;
using myDiscogs.DiscogsApi;
using myDiscogs.Models.Wantlist;
using Newtonsoft.Json;

namespace myDiscogs.Controllers
{
    public class WantsController : Controller
    {
        private myDiscogsContext db = new myDiscogsContext();
        private DiscogsClient client = new DiscogsClient();

        // GET: Wants
        public ActionResult Index()
        {
            var wantlistData = client.GetWantList();
            var wantlist = JsonConvert.DeserializeObject<PaginatedWantlist>(wantlistData);

            return View(wantlist.Wants);
        }

        // GET: Wants/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Want want = db.Wants.Find(id);
            if (want == null)
            {
                return HttpNotFound();
            }
            return View(want);
        }

        // GET: Wants/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Wants/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ResourceUrl,DateAdded,Rating,Notes")] Want want)
        {
            if (ModelState.IsValid)
            {
                db.Wants.Add(want);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(want);
        }

        // GET: Wants/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Want want = db.Wants.Find(id);
            if (want == null)
            {
                return HttpNotFound();
            }
            return View(want);
        }

        // POST: Wants/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ResourceUrl,DateAdded,Rating,Notes")] Want want)
        {
            if (ModelState.IsValid)
            {
                db.Entry(want).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(want);
        }

        // GET: Wants/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Want want = db.Wants.Find(id);
            if (want == null)
            {
                return HttpNotFound();
            }
            return View(want);
        }

        // POST: Wants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Want want = db.Wants.Find(id);
            db.Wants.Remove(want);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
