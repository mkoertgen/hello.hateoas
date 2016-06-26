using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

namespace hello.hateoas
{
    public class LinksFromJson : IGetLinks
    {
        // TODO: links from Headers, cf.: https://developer.github.com/v3/#link-header

        public IEnumerable<Link> GetLinks(JToken json, string jpath = "$..*")
        {
            var tokens = json.SelectTokens(jpath, false)
                .Where(IsUrl).ToList();

            return tokens.Select(t => new Link
            {
                Rel = t.Path,
                Href = t.Value<string>()
            });
        }

        private static readonly Regex RxUrl = new Regex(@"^\w+://\w+", RegexOptions.Compiled);
        private static bool IsUrl(JToken jtoken)
        {
            return jtoken.Type == JTokenType.String && RxUrl.IsMatch(jtoken.Value<string>());
        }
    }
}
