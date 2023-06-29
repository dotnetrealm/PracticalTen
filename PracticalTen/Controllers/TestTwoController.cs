using Microsoft.AspNetCore.Mvc;
using PracticalTen.Common;

namespace PracticalTen.Controllers
{
    public class TestTwoController : Controller
    {
        private readonly IWebHostEnvironment _env;
        public TestTwoController(IWebHostEnvironment env)
        {
            _env = env;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 300, Location = ResponseCacheLocation.Any)]
        public FileContentResult GetFileContentResult()
        {
            byte[] file = System.IO.File.ReadAllBytes(Path.Combine(_env.WebRootPath, "data/Sample.txt"));
            return File(file, "text/plain");
        }

        public ContentResult GetContentResult()
        {
            return Content("<h3>This is from ContentResult method</h3>");
        }

        public EmptyResult GetEmptyResult()
        {
            return new EmptyResult();
        }

        public JavascriptResult GetJavascriptResult()
        {
            string jsScript = "alert('Hello World!');";
            return new JavascriptResult(jsScript);
        }

        public JsonResult GetJsonResult()
        {
            string fileData = System.IO.File.ReadAllText(Path.Combine(_env.WebRootPath, "data/People.json"));
            return Json(fileData);
        }

        public PartialViewResult GetPartialViewResult()
        {
            ViewBag.Message = $"This is PartialViewResult result!";
            return PartialView("_details");
        }

        [ResponseCache(Duration = 20, Location = ResponseCacheLocation.Any)]
        public int GetTime()
        {
            return DateTime.Now.Second;
        }
    }
}
