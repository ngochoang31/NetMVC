using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;
namespace DemoMVC.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    public class Bai2Controller : Controller
    {
        
        public IActionResult Index()
        {
            ViewBag.Result = "May Tinh Co Ban";
            return View();
        }

        [HttpPost]
        public IActionResult Index(Bai2 ps)
        {
            ViewBag.Result = "Ket qua:" + " " + ps.Result;
            return View();
        }


    }
  
}
