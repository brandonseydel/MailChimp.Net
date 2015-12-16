using System.Collections.Generic;
using MailChimp.Net.Core;
using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Member
    {
        public Member()
        {
            Links = new HashSet<Link>();
            MergeFields = new Dictionary<string, string>();
        }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("unique_email_id")]
        public string UniqueEmailId { get; set; }

        [JsonProperty("email_type")]
        public string EmailType { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof (StringEnumDescriptionConverter))]
        public Status Status { get; set; }

        [JsonProperty("status_if_new")]
        public string StatusIfNew { get; set; }

        [JsonProperty("merge_fields")]
        public Dictionary<string, string> MergeFields { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("ip_signup")]
        public string IpSignup { get; set; }

        [JsonProperty("timestamp_signup")]
        public string TimestampSignup { get; set; }

        [JsonProperty("ip_opt")]
        public string IpOpt { get; set; }

        [JsonProperty("timestamp_opt")]
        public string TimestampOpt { get; set; }

        [JsonProperty("member_rating")]
        public int MemberRating { get; set; }

        [JsonProperty("last_changed")]
        public string LastChanged { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("vip")]
        public bool Vip { get; set; }

        [JsonProperty("email_client")]
        public string EmailClient { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("list_id")]
        public string ListId { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }
    }
}

