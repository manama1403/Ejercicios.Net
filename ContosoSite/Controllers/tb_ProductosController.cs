using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ContosoSite.Models;

namespace ContosoSite.Controllers
{
    public class tb_ProductosController : Controller
    {
        private MiSitioEntities db = new MiSitioEntities();

        // GET: tb_Productos
        public ActionResult Index()
        {
            return View(db.tb_Productos.ToList());
        }

        // GET: tb_Productos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Productos tb_Productos = db.tb_Productos.Find(id);
            if (tb_Productos == null)
            {
                return HttpNotFound();
            }
            return View(tb_Productos);
        }

        // GET: tb_Productos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tb_Productos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_Producto,DESCRIPCION")] tb_Productos tb_Productos)
        {
            if (ModelState.IsValid)
            {
                db.tb_Productos.Add(tb_Productos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_Productos);
        }

        // GET: tb_Productos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Productos tb_Productos = db.tb_Productos.Find(id);
            if (tb_Productos == null)
            {
                return HttpNotFound();
            }
            return View(tb_Productos);
        }

        // POST: tb_Productos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_Producto,DESCRIPCION")] tb_Productos tb_Productos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_Productos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_Productos);
        }

        // GET: tb_Productos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Productos tb_Productos = db.tb_Productos.Find(id);
            if (tb_Productos == null)
            {
                return HttpNotFound();
            }
            return View(tb_Productos);
        }

        // POST: tb_Productos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tb_Productos tb_Productos = db.tb_Productos.Find(id);
            db.tb_Productos.Remove(tb_Productos);
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
