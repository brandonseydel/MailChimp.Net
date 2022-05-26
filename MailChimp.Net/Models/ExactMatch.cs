using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;

namespace MailChimp.Net.Models
{
    public class ExactMatch : Base
    {
        public ExactMatch()
        {
            Members = new HashSet<Member>();
        }

        [JsonProperty("members")]
        public IEnumerable<Member> Members { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Data.AddExpression(TotalItems)
                ;
        }
    }

}
