using Newtonsoft.Json;
using System.Diagnostics;

namespace MailChimp.Net.Models
{
    public class Result : Base
    {
        [JsonProperty("campaign")]
        public Campaign Campaign { get; set; }

        [JsonProperty("snippet")]
        public string Snippet { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Data.Add(Snippet)
                ;
        }
    }
}
