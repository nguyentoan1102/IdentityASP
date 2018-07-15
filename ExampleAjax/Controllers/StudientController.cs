using ExampleAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleAjax.Controllers
{
    public class StudientController : Controller
    {
        // GET: Studient
        private StudentContext context = new StudentContext();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateStudent(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            string message = "SUCCESS";
            return Json(new { message, JsonRequestBehavior.AllowGet });
        }

        //[HttpGet]
        public JsonResult GetStudent(string id)
        {
            var students = context.Students.ToList();
            return Json(students, JsonRequestBehavior.AllowGet);
        }
    }
}