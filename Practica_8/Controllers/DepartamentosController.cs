﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Practica_8.Models.DAL;
using Practica_8.Models.Models;

namespace Practica_8.Controllers
{
    public class DepartamentosController : Controller
    {
        private EmpleadoContext db = new EmpleadoContext();

        // GET: Departamentos
        public ActionResult Index()
        {
            return View(db.Departamentos.ToList());
        }

        // GET: Departamentos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Departamento departamento = db.Departamentos.Find(id);
            if (departamento == null)
            {
                return HttpNotFound();
            }
            return View(departamento);
        }

        // GET: Departamentos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Departamentos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DepartamentoId,Descripcion")] Departamento departamento)
        {
            if (ModelState.IsValid)
            {
                db.Departamentos.Add(departamento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(departamento);
        }

        // GET: Departamentos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Departamento departamento = db.Departamentos.Find(id);
            if (departamento == null)
            {
                return HttpNotFound();
            }
            return View(departamento);
        }

        // POST: Departamentos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DepartamentoId,Descripcion")] Departamento departamento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(departamento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(departamento);
        }

        // GET: Departamentos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Departamento departamento = db.Departamentos.Find(id);
            if (departamento == null)
            {
                return HttpNotFound();
            }
            return View(departamento);
        }

        // POST: Departamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Departamento departamento = db.Departamentos.Find(id);
            db.Departamentos.Remove(departamento);
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
