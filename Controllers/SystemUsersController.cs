using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SaristhBookstore.Data;
using SaristhBookstore.Models;

namespace SaristhBookstore.Controllers
{
  
    public class SystemUsersController : Controller
    {
        private SaristhBookstoreContext db = new SaristhBookstoreContext();

        // GET: SystemUsers
        public async Task<ActionResult> Index()
        {
            return View(await db.SystemUsers.ToListAsync());
        }

        // GET: SystemUsers/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SystemUser systemUser = await db.SystemUsers.FindAsync(id);
            if (systemUser == null)
            {
                return HttpNotFound();
            }
            return View(systemUser);
        }
        public async Task<ActionResult> LogOut()
        {
            AppManage.LoggedInUserId = 0;
            AppManage.LoggedInTypeId = 0;
            return RedirectToAction( "LogIn");

        }
        public async Task<ActionResult> LogIn(string username , string password)
        {
            if(username == null && password == null)
            {
                return View();
            } else
            {
                if (ModelState.IsValid)
                {
                    var user = db.SystemUsers.SingleOrDefaultAsync(a => a.UserName == username && a.password == password).Result;
                    if (user != null)
                    {
                        AppManage.LoggedInUserId = user.Id;
                        AppManage.LoggedInTypeId = user.userTypeId;
                        if (user.userTypeId == 1)
                        {
                            return RedirectToAction("Index", "Orders");
                        }
                        else
                        {
                            return RedirectToAction("Store", "Books");

                        }
                    }
                    else
                    {
                        return View();
                    }
                }
                return View();

            }
             ;
        }
       

        // GET: SystemUsers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SystemUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,UserName,password")] SystemUser systemUser)
        {
            if (ModelState.IsValid)
            {
                db.SystemUsers.Add(systemUser);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(systemUser);
        }

        // GET: SystemUsers/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SystemUser systemUser = await db.SystemUsers.FindAsync(id);
            if (systemUser == null)
            {
                return HttpNotFound();
            }
            return View(systemUser);
        }

        // POST: SystemUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,UserName,password")] SystemUser systemUser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(systemUser).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(systemUser);
        }

        // GET: SystemUsers/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SystemUser systemUser = await db.SystemUsers.FindAsync(id);
            if (systemUser == null)
            {
                return HttpNotFound();
            }
            return View(systemUser);
        }

        // POST: SystemUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            SystemUser systemUser = await db.SystemUsers.FindAsync(id);
            db.SystemUsers.Remove(systemUser);
            await db.SaveChangesAsync();
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
