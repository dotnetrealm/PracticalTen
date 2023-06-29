using Microsoft.AspNetCore.Mvc;

namespace PracticalTen.Controllers
{
    public class TestFourController : Controller
    {   
        public IActionResult Index()
        {
            throw new DivideByZeroException();
        }
    }
}
