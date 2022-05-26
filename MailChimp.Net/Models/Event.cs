using Newtonsoft.Json;
using System.Diagnostics;

namespace MailChimp.Net.Models
{
    public class Event : Base
    {
        [JsonProperty("subscribe")]
        public bool Subscribe { get; set; }

        [JsonProperty("unsubscribe")]
        public bool Unsubscribe { get; set; }

        [JsonProperty("profile")]
        public bool Profile { get; set; }

        [JsonProperty("cleaned")]
        public bool Cleaned { get; set; }

        [JsonProperty("upemail")]
        public bool Upemail { get; set; }

        [JsonProperty("campaign")]
        public bool Campaign { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Data.AddFlag(Subscribe)
                .Data.AddFlag(Unsubscribe)
                .Data.AddFlag(Profile)
                .Data.AddFlag(Cleaned)
                .Data.AddFlag(Upemail)
                .Data.AddFlag(Campaign)
                ;
        }
    }
}
