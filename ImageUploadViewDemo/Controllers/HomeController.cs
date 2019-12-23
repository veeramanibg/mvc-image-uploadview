using ImageUploadViewDemo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImageUploadViewDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Employee employee)
        {
            string fileName = Path.GetFileNameWithoutExtension(employee.ImageFile.FileName);
            string fileExtension = Path.GetExtension(employee.ImageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + fileExtension;
            employee.ImagePath = "~/Image/" + fileName;

            fileName = Path.Combine(Server.MapPath("~/Image/"), fileName);
            employee.ImageFile.SaveAs(fileName);
            using(EmployeeContext context=new EmployeeContext())
            {
                context.Employees.Add(employee);
                context.SaveChanges();
            }
            return View();

        }

        [HttpGet]
        public ActionResult View(int id)
        {
            Employee employee = new Employee();
            using(EmployeeContext context=new EmployeeContext())
            {
                employee = context.Employees.Where(x => x.ID == id).FirstOrDefault();
            }
            return View(employee);
        }
    }
}