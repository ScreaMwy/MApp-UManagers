using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MWeb.Untiy
{
    public static class HtmlHelperExtensions
    {
        public static IHtmlContent Br(this IHtmlHelper htmlHelper)
        {
            return new HtmlString("</br>");
        }

        public static IHtmlContent Img(this IHtmlHelper htmlHelper, string src)
        {
            return new HtmlString($"<img src={src}></img>");
        }

        public static string ShowString(this string @string)
        {
            var tempString = @string.Insert(@string.Length, "24726");
            return tempString;
        }
    }
}
