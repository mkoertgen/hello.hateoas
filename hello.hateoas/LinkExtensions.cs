using System.Text.RegularExpressions;

namespace hello.hateoas
{
    internal static class LinkExtensions
    {
        private static readonly Regex RxUrlTemplate = new Regex(@"{.+}", RegexOptions.Compiled);

        public static bool IsTemplate(this Link link)
        {
            return !string.IsNullOrWhiteSpace(link.Href) && RxUrlTemplate.IsMatch(link.Href);
        }
    }
}