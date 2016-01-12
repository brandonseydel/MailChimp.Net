using Newtonsoft.Json;

namespace Example.SampleResponse1JsonTypes
{
    public class Link
    {

        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("targetSchema")]
        public string TargetSchema { get; set; }
    }
}