using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class SentTo
    {

        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("open_count")]
        public int OpenCount { get; set; }

        [JsonProperty("last_open")]
        public string LastOpen { get; set; }

        [JsonProperty("absplit_group")]
        public string AbsplitGroup { get; set; }

        [JsonProperty("gmt_offset")]
        public int GmtOffset { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("list_id")]
        public string ListId { get; set; }

        [JsonProperty("_links")]
        public Link[] Links { get; set; }
    }
}