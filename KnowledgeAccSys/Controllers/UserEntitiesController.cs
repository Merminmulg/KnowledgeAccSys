using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KnowledgeAccSys.Models;
using BL;
using BL.Models;

namespace KnowledgeAccSys.Controllers
{
    public class UserEntitiesController : Controller
    {
        private DataBase db = new DataBase();

        // GET: UserEntities
        public ActionResult Index()
        {
            return View(db.GetUsersList());
        }

        // GET: UserEntities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User userEntity = db.GetUsersList().Where(x=>x.UserID==id).Single();
            if (userEntity == null)
            {
                return HttpNotFound();
            }
            return View(userEntity);
        }

        // GET: UserEntities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserEntities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserID,Login,Password,Admin,Manager")] UserEntity userEntity)
        {
            if (ModelState.IsValid)
            {
                db.AddUser(new User
                {
                    Login = userEntity.Login,
                    Admin = userEntity.Admin,
                    Password = userEntity.Password,
                    UserID = userEntity.UserID,
                    Manager = userEntity.Manager
                });
                return RedirectToAction("Index");
            }

            return View(userEntity);
        }

        // GET: UserEntities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User userEntity = db.GetUsersList().Where(x => x.UserID == id).Single();
            if (userEntity == null)
            {
                return HttpNotFound();
            }
            return View(userEntity);
        }

        // POST: UserEntities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserID,Login,Password,Admin,Manager")] UserEntity userEntity)
        {
            if (ModelState.IsValid)
            {
                db.EditUser(db.GetUsersList().Where(x => x.UserID == userEntity.UserID).Single());
                return RedirectToAction("Index");
            }
            return View(userEntity);
        }

        // GET: UserEntities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User userEntity = db.GetUsersList().Where(x => x.UserID == id).Single();
            if (userEntity == null)
            {
                return HttpNotFound();
            }
            return View(userEntity);
        }

        // POST: UserEntities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User userEntity = db.GetUsersList().Where(x => x.UserID == id).Single();
            db.DeleteUser(userEntity);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.BDDispose();
            }
            base.Dispose(disposing);
        }
    }
}
