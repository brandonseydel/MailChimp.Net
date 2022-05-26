using Newtonsoft.Json;
using System.Diagnostics;

namespace MailChimp.Net.Models
{
    public class ListActivity : Base
    {

        [JsonProperty("day")]
        public string Day { get; set; }

        [JsonProperty("emails_sent")]
        public int EmailsSent { get; set; }

        [JsonProperty("unique_opens")]
        public int UniqueOpens { get; set; }

        [JsonProperty("recipient_clicks")]
        public int RecipientClicks { get; set; }

        [JsonProperty("hard_bounce")]
        public int HardBounce { get; set; }

        [JsonProperty("soft_bounce")]
        public int SoftBounce { get; set; }

        [JsonProperty("subs")]
        public int Subs { get; set; }

        [JsonProperty("unsubs")]
        public int Unsubs { get; set; }

        [JsonProperty("other_adds")]
        public int OtherAdds { get; set; }

        [JsonProperty("other_removes")]
        public int OtherRemoves { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Prefix.Add(Day)
                .Data.AddExpression(Subs)
                .Data.AddExpression(Unsubs)
                ;
        }
    }
}
