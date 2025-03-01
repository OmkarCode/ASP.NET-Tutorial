using Microsoft.AspNetCore.Mvc;

namespace BasicConcepts.Controllers
{
    public class AdditionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormCollection obj)
        {
            int num1 = Convert.ToInt32(obj["txtnum1"].ToString());
            int num2 = Convert.ToInt32(obj["txtnum2"].ToString());
            int num3 = num1 + num2;  

            ViewBag.data = "Result is " + num3;
            return View();
        }
    }
}
