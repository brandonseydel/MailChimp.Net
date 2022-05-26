using Newtonsoft.Json;
using System.Diagnostics;

namespace MailChimp.Net.Models
{
    public class Promo : Base
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("amount_discounted")]
        public decimal AmountDiscounted { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Type.Add(Type)
                .Data.AddExpression(AmountDiscounted)
                .Postfix.Add(Code)
                ;
        }
    }
}