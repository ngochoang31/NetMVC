
using DemoMVC.Models;
namespace DemoMVC.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    public class Bai1Controller : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "...";
            return View();
        }

        [HttpPost]
        public IActionResult Index(Bai1 ps)
        {
            ViewBag.Message = "" + ps.FullName + "-" + ps.Age;
            return View();
        }


    }
}