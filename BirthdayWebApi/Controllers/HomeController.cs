using BirthdayWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace BirthdayWebApi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult InvitationForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult InvitationForm(InvitationModel model)
        {
            if (ModelState.IsValid)
            {
                Database.Add(model);
                return View("Thanks", model);
            }
            return View(model);
        }
        [ChildActionOnly]
        public ActionResult Attendees()
        {
            return PartialView(Database.List.Where(i => i.JoiningCase == true));
        }
    }
}