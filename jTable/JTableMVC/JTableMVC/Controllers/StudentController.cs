using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Datalayer;

namespace JTableMVC.Controllers
{
    public class StudentController : Controller
    {
        //
        // GET: /Student/

        private StudentRepository _studentRepository = new StudentRepository();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult StudentList()
        {
            try
            {
                IList<Student> students = _studentRepository.GetAllStudents();
                return Json(new { Result = "OK", Records = students });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }
    }
}
