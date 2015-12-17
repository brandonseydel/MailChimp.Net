using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Content
    {

        [JsonProperty("plain_text")]
        public string PlainText { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("_links")]
        public Link[] Links { get; set; }
    }

}
