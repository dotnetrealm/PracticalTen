using Microsoft.AspNetCore.Mvc;

namespace PracticalTen.Common
{
    public class JavascriptResult : ContentResult
    {
        public JavascriptResult(string value)
        {
            this.Content = value;
            this.ContentType = "application/javascript";
        }
    }
}
