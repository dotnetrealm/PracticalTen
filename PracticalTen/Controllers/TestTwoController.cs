using Microsoft.AspNetCore.Mvc;
using PracticalTen.Common;

namespace PracticalTen.Controllers
{
    public class TestTwoController : Controller
    {
        private readonly IWebHostEnvironment _env;
        public TestTwoController(IWebHostEnvironment enviorment)
        { 
            _env = enviorment;
        }

        /// <summary>
        /// To display string on web page
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Return plain text file
        /// </summary>
        /// <returns></returns>
        [ResponseCache(Duration = 300, Location = ResponseCacheLocation.Any)]
        public FileContentResult GetFileContentResult()
        {
            byte[] file = System.IO.File.ReadAllBytes(Path.Combine(_env.WebRootPath, "data/Sample.txt"));
            return File(file, "text/plain");
        }

        /// <summary>
        /// Return simple content
        /// </summary>
        /// <returns></returns>
        public ContentResult GetContentResult()
        {
            return Content("<h3>This is from ContentResult method</h3>");
        }

        /// <summary>
        /// Return empty result
        /// </summary>
        /// <returns></returns>
        public EmptyResult GetEmptyResult()
        {
            return new EmptyResult();
        }

        /// <summary>
        /// Return Javascript content
        /// </summary>
        /// <returns></returns>
        public JavascriptResult GetJavascriptResult()
        {
            string jsScript = "alert('Hello World!');";
            return new JavascriptResult(jsScript);
        }

        /// <summary>
        /// Retrive people data
        /// </summary>
        /// <returns></returns>
        public JsonResult GetJsonResult()
        {
            string fileData = System.IO.File.ReadAllText(Path.Combine(_env.WebRootPath, "data/People.json"));
            return Json(fileData);
        }

        /// <summary>
        /// Partial view with message
        /// </summary>
        /// <returns></returns>
        public PartialViewResult GetPartialViewResult()
        {
            ViewBag.Message = $"This is PartialViewResult result!";
            return PartialView("_details");
        }
    }
}
