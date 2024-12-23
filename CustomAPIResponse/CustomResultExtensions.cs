
namespace ApiCustomResult.CustomAPIResponse{

    public static class CustomResultExtensions{

        public static IResult HtmlResponse(this IResultExtensions extensions, string html){
            return new CustomHTMLResult(html);
        }
    }
}