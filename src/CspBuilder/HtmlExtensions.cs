using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BarSpace.CspBuilder
{
    public static class HtmlExtensions
    {
        public static IHtmlContent AddCsp(this IHtmlHelper html, CspBuilder builder)
        {
            return new HtmlString($"<meta http-equiv=\"Content-Security-Policy\" content=\"{builder.Build()}\" />");
        }
    }
}
