using GoodsForAll.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodsForAll.Controllers
{
    public class UserController : Controller
    {
        private ApplicationDbContext context;
        public UserController()
        {
            context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            context.Dispose();
        }
        [HttpPost]
        public ActionResult UpdateUserProfile(NormalUser normalUser)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new NormalUser
                {
                    name = normalUser.name,
                    phone = normalUser.phone,
                    location = normalUser.location
                };
                return View("UserProfile", viewModel);
            }
            if (normalUser.id == null)
                context.NormalUsers.Add(normalUser);
            else
            {
                var userInDb = context.NormalUsers.Single(c => c.id == normalUser.id);
                userInDb.name = normalUser.name;
                userInDb.phone = normalUser.phone;
                userInDb.location = normalUser.location;
            }
            context.SaveChanges();
            return RedirectToAction("UserProfile", "User",new { id = User.Identity.GetUserId() });
        }
        public ActionResult UserProfile(string id)
        {
            var viewModel = context.NormalUsers.SingleOrDefault(c => c.id == id);
            return View(viewModel);
        }
    }
}