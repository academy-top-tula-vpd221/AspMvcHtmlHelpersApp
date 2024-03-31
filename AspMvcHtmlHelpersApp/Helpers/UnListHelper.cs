using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.Encodings.Web;

namespace AspMvcHtmlHelpersApp.Helpers
{
    public static class UnListHelper
    {
        public static HtmlString CreateList(this IHtmlHelper html, IEnumerable<string> items)
        {
            //string result = "<ul>";
            //foreach (var item in items)
            //    result += $"<li>{item}</li>";
            //result += "</ul>";

            //return new HtmlString(result);

            TagBuilder ul = new("ul");
            foreach (var item in items)
            {
                TagBuilder li = new("li");
                li.InnerHtml.AppendHtml(item);
                li.Attributes.Add("class", "list-group-item");
                ul.InnerHtml.AppendHtml(li);
            }

            ul.Attributes.Add("class", "list-group");
            using(StringWriter writer = new StringWriter())
            {
                ul.WriteTo(writer, HtmlEncoder.Default);
                return new HtmlString(writer.ToString());
            }
            
        }
    }
}
