using DropdownProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropdownProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Student stud, string csharp, string java, string php)
        {
            string course=string.Empty;
            if (csharp == "true")
            {
                course = course + "C#" + ",";
            }
            if (java == "true")
            {
                course = course + "Java" + ",";
            }
            if (php == "true")
            {
                course = course + "PHP" + ",";
            }
            stud.Country = course;
            Student obj=new Student();
            obj.AddStudent(stud);
            return View();
        }
    }
}