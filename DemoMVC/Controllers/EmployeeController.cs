using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;   

namespace DemoMVC.Controllers
{
    public class EmployeeController : Controller
    {
    
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Employee ps)
        {
            string strOutput = "Xin chào " + ps.EmployeeId + " - " + ps.Age;
            ViewBag.Message = strOutput;
            return View();
        }
    }
}