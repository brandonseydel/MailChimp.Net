using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class VariateSettings : Base
    {
        [JsonProperty("winning_combination_id")]
        public string WinningCombinationId { get; set; }

        [JsonProperty("winning_campaign_id")]
        public string WinningCampaignId { get; set; }

        [JsonProperty("winner_criteria")]
        public string WinnerCriteria { get; set; }

        [JsonProperty("combinations")]
        public IEnumerable<Combination> Combinations { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Data.AddExpression(WinnerCriteria)
                ;
        }
    }
}
