using Newtonsoft.Json;
using System.Diagnostics;

namespace MailChimp.Net.Models
{
    public class Source : Base
    {
        [JsonProperty("user")]
        public bool User { get; set; }

        [JsonProperty("admin")]
        public bool Admin { get; set; }

        [JsonProperty("api")]
        public bool Api { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Data.AddFlag(User)
                .Data.AddFlag(Admin)
                .Data.AddFlag(Api)
                ;
        }
    }
}
