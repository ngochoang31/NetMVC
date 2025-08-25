namespace DemoMVC.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Hello";
            return View();
        }


    }
}