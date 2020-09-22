using GoodsForAll.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodsForAll.Controllers
{
    public class VolunterController : Controller
    {
        private ApplicationDbContext context;
        public VolunterController()
        {
            context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            context.Dispose();
        }
        [HttpPost]
        public ActionResult UpdateUserProfile(Volunter volunter)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new Volunter
                {
                    name = volunter.name,
                    phone = volunter.phone,
                    location = volunter.location
                };
                return View("UserProfile", viewModel);
            }
            if (volunter.id == null)
                context.Volunters.Add(volunter);
            else
            {
                var userInDb = context.Volunters.Single(c => c.id == volunter.id);
                userInDb.name = volunter.name;
                userInDb.phone = volunter.phone;
                userInDb.location = volunter.location;
            }
            context.SaveChanges();
            return RedirectToAction("UserProfile", "Volunter", new { id = User.Identity.GetUserId() });
        }
        public ActionResult UserProfile(string id)
        {
            var viewModel = context.Volunters.SingleOrDefault(c => c.id == id);
            return View(viewModel);
        }
    }
}