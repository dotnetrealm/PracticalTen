using Microsoft.AspNetCore.Mvc;

namespace PracticalTen.Controllers
{
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        [Route("~/")]
        [Route("{Name?}")]
        [Route("[action]/{Name?}")]
        public IActionResult Index(string Name = "John")
        {
            ViewBag.Name = Name;
            return View();
        }
    }
}