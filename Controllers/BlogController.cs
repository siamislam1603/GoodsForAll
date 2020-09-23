using GoodsForAll.Models;
using GoodsForAll.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace GoodsForAll.Controllers
{
    public class BlogController : Controller
    {
        private ApplicationDbContext context;
        public BlogController()
        {
            context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            context.Dispose();
        }
        [HttpPost]
        public ActionResult UpdateBlog(DonationFormViewModel donation) {
            if (!ModelState.IsValid)
            {
                var viewModel = new DonationFormViewModel
                {
                    item = donation.item,
                    donationtype = context.DonationTypes.ToList()
                };
                return View("DonationForm", viewModel);
            }
            if (donation.item.id == 0)
            {
                donation.item.NormalUserId = User.Identity.GetUserId();
                context.Items.Add(donation.item);
            }
            else
            {
                var itemInDb = context.Items.Single(c => c.id == donation.item.id);
                itemInDb.name = donation.item.name;
                itemInDb.date = donation.item.date;
                itemInDb.DonationTypeId = donation.item.DonationTypeId;
                itemInDb.quantity = donation.item.quantity;
                itemInDb.NormalUserId = User.Identity.GetUserId();
            }
            context.SaveChanges();
            return RedirectToAction("DonationForm", "Blog");
        }
        public ActionResult DonationForm()
        {
            var donationType = context.DonationTypes.ToList();
            var viewModel = new DonationFormViewModel
            {
                normalUser = new NormalUser(),
                donationtype = donationType,
                item = new Item()
            };
            return View(viewModel);
        }
        public ActionResult Blogs()
        {
            var items = context.Items.Include(i => i.NormalUser).Include(i => i.DonationType).ToList();
            return View(items);
        }
        public ActionResult EditBlogInfo(int id)
        {
            var Item = context.Items.SingleOrDefault(c => c.id == id);
            if (Item == null)
                return HttpNotFound();
            var viewModel = new DonationFormViewModel
            {
                item = Item,
                donationtype = context.DonationTypes.ToList()
            };
            return View("DonationForm", viewModel);
        }
    }
}