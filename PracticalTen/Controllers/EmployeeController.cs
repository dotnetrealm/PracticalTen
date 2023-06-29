using Microsoft.AspNetCore.Mvc;

namespace PracticalTen.Controllers
{
    public class EmployeeController : Controller
    {
        [Route("[controller]/{Name?}")]
        [Route("[controller]/[action]/{Name?}")]
        public IActionResult Index(string Name = "Bhavin")
        {
            ViewBag.Name = Name;
            return View();
        }
    }
}