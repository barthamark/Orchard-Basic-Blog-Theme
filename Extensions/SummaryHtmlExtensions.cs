using Orchard.Mvc.Html;

namespace System.Web.Mvc
{
    public static class SummaryHtmlExtensions
    {
        public static IHtmlString CreateHtmlSummary(this HtmlHelper html, string text, int length, bool keepOnlyTheFirstParagraph = false)
        {
            var shortText = html
                .Excerpt(text, length)
                .ToString()
                .Replace(Environment.NewLine, "</p>" + Environment.NewLine + "<p>");

            if (keepOnlyTheFirstParagraph)
            {
                var firstParagraphEndIndex = shortText.IndexOf(Environment.NewLine);
                if (firstParagraphEndIndex > 0)
                {
                    shortText = shortText.Substring(0, firstParagraphEndIndex);
                }
            }

            return new HtmlString(shortText);
        }
    }
}