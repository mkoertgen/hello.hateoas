using Newtonsoft.Json;

namespace hello.hateoas
{
    public class Link
    {
        [JsonProperty("rel")]
        public string Rel { get; set; }
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}