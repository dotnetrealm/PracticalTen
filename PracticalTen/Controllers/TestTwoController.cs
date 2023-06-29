using Microsoft.AspNetCore.Mvc;
using PracticalTen.Common;
using System.Net.Mime;

namespace PracticalTen.Controllers
{
    [Route("[controller]/[action]")]
    public class TestTwoController : Controller
    {
        private IWebHostEnvironment _env;
        public TestTwoController(IWebHostEnvironment env)
        {
            _env = env;
        }
        public IActionResult Index()
        {
            return View();
        }

        public FileContentResult GetFileContentResult()
        {
            var file = System.IO.File.ReadAllBytes(Path.Combine(_env.WebRootPath, "data/sample.pdf"));
            return new FileContentResult(file, "application/pdf");
        }

        public ContentResult GetContentResult()
        {
            return Content("<h3>Hello World</h3>");
        }

        public EmptyResult GetEmptyResult()
        {
            return new EmptyResult();
        }

        public JavascriptResult GetJavascriptResult()
        {
            var jsScript = "alert('Hello World!');";
            return new JavascriptResult(jsScript);
        }

        public JsonResult GetJsonResult()
        {
            var fileData = System.IO.File.ReadAllText(Path.Combine(_env.WebRootPath, "data/People.json"));
            return Json(fileData);
        }

        public IActionResult GetPartialViewResult()
        {
            ViewBag.Message = "This content is loaded using partial view!";
            return PartialView("_details");
        }
    }
}
