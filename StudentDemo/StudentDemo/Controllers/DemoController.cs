using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentDemo.Models;

namespace StudentDemo.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        [HttpGet]
        public ActionResult Index()
        {
            Student st = new Student();
            st.StudentId = 01;
            st.FullName = "Hugo Sanchez";
            return View(st);
        }

        [HttpPost]
        public ActionResult Index(FormCollection f)
        {
            Student st = new Student();
            st.StudentId = int.Parse(f["txtStudentID"].ToString());
            st.FullName = f.Get("txtName").ToString();
            return View(st);
        }
    }
}