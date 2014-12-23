using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult RazorView()
        {
            return View();    
        }

        [HttpPost]
        public ActionResult FormSubmit(Student student)
        {
            string txtBox1Val = Request.Form["textBox1"];
            string txtBox2Val = Request.Form["textBox2"];
            string txtBox3Val = Request.Form["textBox3"]; ;
            return View("RazorView");
        }
    }
}
