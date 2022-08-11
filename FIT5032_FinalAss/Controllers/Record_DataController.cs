using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FIT5032_FinalAss.Models;

namespace FIT5032_FinalAss.Controllers
{
    public class Record_DataController : Controller
    {
        private Rccord_Model db = new Rccord_Model();

        // GET: Record_Data
        public ActionResult Index()
        {
            return View(db.Record_Data.ToList());
        }

        // GET: Record_Data/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Record_Data record_Data = db.Record_Data.Find(id);
            if (record_Data == null)
            {
                return HttpNotFound();
            }
            return View(record_Data);
        }

        // GET: Record_Data/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Record_Data/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,first_name,gender,ICD10,Drug")] Record_Data record_Data)
        {
            if (ModelState.IsValid)
            {
                db.Record_Data.Add(record_Data);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(record_Data);
        }

        // GET: Record_Data/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Record_Data record_Data = db.Record_Data.Find(id);
            if (record_Data == null)
            {
                return HttpNotFound();
            }
            return View(record_Data);
        }

        // POST: Record_Data/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,first_name,gender,ICD10,Drug")] Record_Data record_Data)
        {
            if (ModelState.IsValid)
            {
                db.Entry(record_Data).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(record_Data);
        }

        // GET: Record_Data/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Record_Data record_Data = db.Record_Data.Find(id);
            if (record_Data == null)
            {
                return HttpNotFound();
            }
            return View(record_Data);
        }

        // POST: Record_Data/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Record_Data record_Data = db.Record_Data.Find(id);
            db.Record_Data.Remove(record_Data);
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
