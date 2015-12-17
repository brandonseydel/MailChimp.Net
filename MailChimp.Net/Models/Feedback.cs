using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
// ReSharper disable UnusedAutoPropertyAccessor.Local

namespace MailChimp.Net.Models
{
    public class Feedback
    {

        [JsonProperty("feedback_id")]
        public int? FeedbackId { get; private set; }

        [JsonProperty("parent_id")]
        public int ParentId { get; private set; }

        [JsonProperty("block_id")]
        public int BlockId { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("is_complete")]
        public bool IsComplete { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; private set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; private set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; private set; }

        [JsonProperty("source")]
        public string Source { get; private set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; private set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; private set; }
    }
}
