using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using PracticalTen.Models;
using System.Diagnostics;
using System.Net;

namespace PracticalTen.Controllers
{
    public class ErrorController : Controller
    {
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("[controller]/{statusCode?}")]
        public IActionResult Error(int statusCode)
        {
            IDictionary<int, string> statusMessages = new Dictionary<int,string>();

            statusMessages.Add(401, "User identity is not found!");
            statusMessages.Add(403, "You don't have permission to access this resources!");
            statusMessages.Add(404, "Sorry, the page you are looking for could not be found.");
            statusMessages.Add(500, "Whoops, something went wrong on our servers!");
            statusMessages.Add(503, "Service unavailable!");

            var feature = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();

            var message = (statusMessages.ContainsKey(statusCode)) ? statusMessages[statusCode] : "Something went wrong!";

            return View(new ErrorViewModel { 
                    RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
                    StatusCode = statusCode,
                    Message = message,
                    OriginalPath = feature?.OriginalPath ?? string.Empty,
                });
        }
    }
}
