using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PhoneBook.Models.DomainModel;

namespace PhoneBook.Controllers
{
    public class TblUsersController : Controller
    {
        private PhoneBookDBEntities db = new PhoneBookDBEntities();

        // GET: TblUsers
        public ActionResult Index() // Show user list
        {
            return View(db.TblUsers.ToList());
        }

        // GET: TblUsers/Details/5
        public ActionResult Details(int? id) // show special user with id
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblUser tblUser = db.TblUsers.Find(id);
            if (tblUser == null)
            {
                return HttpNotFound();
            }
            return View(tblUser);
        }

        // GET: TblUsers/Create
        public ActionResult Create() // show add form user
        {
            return View();
        }

        // POST: TblUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Firstname,Lastname,Mobile,PhoneNumber,NationalCode,cGroup,Picture,ImageName")] TblUser tblUser,HttpPostedFileBase UploadImage) // send user info to db
        {
            //Image Upload
            if (UploadImage!=null)
            {
                if (UploadImage.ContentLength>0)
                {
                    //check Extension
                    string ext = Path.GetExtension(UploadImage.FileName.ToLower());
                    if (ext==".jpg" || ext==".png" || ext==".jpeg")
                    {
                        tblUser.ImageName = UploadImage.FileName;
                        string Pict = Path.GetFileName(UploadImage.FileName);
                        string path = Path.Combine(Server.MapPath("~/Images/"), Pict);
                        UploadImage.SaveAs(path);

                    }
                }
            }    

            if (ModelState.IsValid)
            {
                db.TblUsers.Add(tblUser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblUser);
        }

        // GET: TblUsers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblUser tblUser = db.TblUsers.Find(id);
            if (tblUser == null)
            {
                return HttpNotFound();
            }
            return View(tblUser);
        }

        // POST: TblUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Firstname,Lastname,Mobile,PhoneNumber,NationalCode,cGroup,Picture,ImageName")] TblUser tblUser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblUser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblUser);
        }

        // GET: TblUsers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblUser tblUser = db.TblUsers.Find(id);
            if (tblUser == null)
            {
                return HttpNotFound();
            }
            return View(tblUser);
        }

        // POST: TblUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TblUser tblUser = db.TblUsers.Find(id);
            db.TblUsers.Remove(tblUser);
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

        [HttpGet]
        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(string NationalCode)
        {
            if (string.IsNullOrEmpty(NationalCode))
            {
                ViewBag.Message = "کد ملی خالی نمی تواند باشد.";
                return View();
            }
            List<TblUser> users= db.TblUsers.Where(t => t.NationalCode.Contains(NationalCode.Trim())).ToList();
            return View(users);
        }



    }
}
