using Microsoft.AspNetCore.Mvc;

namespace PracticalTen.Controllers
{
    public class TestFourController : Controller
    {   
        /// <summary>
        /// Generate DivideByZeroException
        /// </summary>
        /// <returns></returns>
        /// <exception cref="DivideByZeroException"></exception>
        public IActionResult Index()
        {
            throw new DivideByZeroException();
        }
    }
}
