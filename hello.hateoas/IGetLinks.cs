using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace hello.hateoas
{
    public interface IGetLinks
    {
        IEnumerable<Link> GetLinks(JToken json, string jpath = "$..*");
    }
}