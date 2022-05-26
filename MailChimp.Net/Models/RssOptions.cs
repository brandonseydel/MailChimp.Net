using Newtonsoft.Json;
using System.Diagnostics;

namespace MailChimp.Net.Models
{
    public class RssOptions : Base
    {
        [JsonProperty("feed_url")]
        public string Url { get; set; }
        [JsonProperty("frequency")]
        public string Frequency { get; set; }
        [JsonProperty("schedule")]
        public Schedule Schedule { get; set; }
        [JsonProperty("constrain_rss_img")]
        public bool ConstrainImage { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Data.Add(Url)
                .Postfix.Add(Frequency)
                ;
        }
    }
}