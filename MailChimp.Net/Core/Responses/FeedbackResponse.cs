using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class FeedBackResponse : BaseResponse
    {
        public FeedBackResponse()
        {
            Feedback = new HashSet<Feedback>();
        }

        [JsonProperty("feedback")]
        public IEnumerable<Feedback> Feedback { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }
    }
}