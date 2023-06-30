using Microsoft.AspNetCore.Mvc;

namespace PracticalTen.Common
{
    /// <summary>
    /// Custom ContentType for Javascript result
    /// </summary>
    public class JavascriptResult : ContentResult
    {
        public JavascriptResult(string value)
        {
            this.Content = value;
            this.ContentType = "application/javascript";
        }
    }
}
