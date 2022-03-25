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
    public class tb_CategoriasController : Controller
    {
        private MiSitioEntities db = new MiSitioEntities();

        // GET: tb_Categorias
        public ActionResult Index()
        {
            return View(db.tb_Categorias.ToList());
        }

        // GET: tb_Categorias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Categorias tb_Categorias = db.tb_Categorias.Find(id);
            if (tb_Categorias == null)
            {
                return HttpNotFound();
            }
            return View(tb_Categorias);
        }

        // GET: tb_Categorias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tb_Categorias/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_Categoria,DesCategoria")] tb_Categorias tb_Categorias)
        {
            if (ModelState.IsValid)
            {
                db.tb_Categorias.Add(tb_Categorias);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_Categorias);
        }

        // GET: tb_Categorias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Categorias tb_Categorias = db.tb_Categorias.Find(id);
            if (tb_Categorias == null)
            {
                return HttpNotFound();
            }
            return View(tb_Categorias);
        }

        // POST: tb_Categorias/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_Categoria,DesCategoria")] tb_Categorias tb_Categorias)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_Categorias).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_Categorias);
        }

        // GET: tb_Categorias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Categorias tb_Categorias = db.tb_Categorias.Find(id);
            if (tb_Categorias == null)
            {
                return HttpNotFound();
            }
            return View(tb_Categorias);
        }

        // POST: tb_Categorias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tb_Categorias tb_Categorias = db.tb_Categorias.Find(id);
            db.tb_Categorias.Remove(tb_Categorias);
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
