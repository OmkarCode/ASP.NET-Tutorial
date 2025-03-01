using Microsoft.AspNetCore.Mvc;
using BasicConcepts.Models;

namespace BasicConcepts.Controllers
{
    public class SIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(SI obj)
        {
            ViewBag.result = "SI is " + (obj.P * obj.R * obj.T) / 100 ;
            return View();
            
        }
    }
}
