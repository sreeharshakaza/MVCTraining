using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDemo1.Models;

namespace MvcDemo1.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/
        private static User users = new User();
        public ActionResult Index()
        {
            ViewBag.Title = "Display Users";
            ViewBag.users = users.userModels;
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(UserModels model)
        {
            users.AddUser(model);
            return RedirectToAction("Index");
        }
    }
}
