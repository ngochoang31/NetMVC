using System.Net;
using System.Data;
namespace DemoMVC.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Hello";

            return View();
        }

        
        [HttpPost]
        public IActionResult Index(string fullname)
        {
            ViewBag.Message = $"Hello, {fullname}";
            return View();
        }
    }
}