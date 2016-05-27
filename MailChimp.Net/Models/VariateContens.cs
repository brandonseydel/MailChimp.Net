using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class VariateContens
    {
        [JsonProperty("content_label")]
        public string ContentLable { get; set; }

        [JsonProperty("plain_text")]
        public string PlainText { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }
    }
}