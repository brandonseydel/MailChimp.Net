using System.Collections.Generic;
using System.Diagnostics;
using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class BatchWebHook : Base, IId<string>
    {

        public string Id { get; set; }
        public string Url { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Id.Add(Id)
                .Data.Add(Url)
                ;
        }

    }

}
