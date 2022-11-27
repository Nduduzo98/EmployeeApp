using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeApp.Controllers
{
    public class HomeController : Controller
    {
        employeedbEntities empEntity = new employeedbEntities();
        public ActionResult Index()
        {
            var listOfData = empEntity.Employees.ToList();
            return View(listOfData);
        }
        
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Create(Employee employee)
        {

            empEntity.Employees.Add(employee);
            empEntity.SaveChanges();
            ViewBag.Message = "Data Saved Successfully";

            return View();
        }


    }
}