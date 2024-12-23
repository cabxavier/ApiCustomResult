
using System.Net.Mime;
using System.Text;

namespace ApiCustomResult.CustomAPIResponse
{
    public class CustomHTMLResult : IResult
    {

        private readonly string htmlContent;

        public CustomHTMLResult(string htmlContent)
        {
            this.htmlContent = htmlContent;
        }

        public async Task ExecuteAsync(HttpContext httpContext)
        {

            httpContext.Response.ContentType = MediaTypeNames.Text.Html;
            httpContext.Response.ContentLength = Encoding.UTF8.GetByteCount(this.htmlContent);
            await httpContext.Response.WriteAsync(htmlContent);
        }

    }
}