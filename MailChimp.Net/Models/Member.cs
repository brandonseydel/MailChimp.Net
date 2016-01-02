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
            Interests = new HashSet<Interest>();
        }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("email_address", NullValueHandling = NullValueHandling.Ignore)]
        public string EmailAddress { get; set; }

        [JsonProperty("unique_email_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UniqueEmailId { get; set; }

        [JsonProperty("email_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EmailType { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof (StringEnumDescriptionConverter))]
        public Status Status { get; set; }

        [JsonProperty("merge_fields", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> MergeFields { get; set; }

        [JsonProperty("interests", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<Interest> Interests { get; set; }

        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public Stats Stats { get; set; }

        [JsonProperty("ip_signup", NullValueHandling = NullValueHandling.Ignore)]
        public string IpSignup { get; set; }

        [JsonProperty("timestamp_signup", NullValueHandling = NullValueHandling.Ignore)]
        public string TimestampSignup { get; set; }

        [JsonProperty("ip_opt", NullValueHandling = NullValueHandling.Ignore)]
        public string IpOpt { get; set; }

        [JsonProperty("timestamp_opt", NullValueHandling = NullValueHandling.Ignore)]
        public string TimestampOpt { get; set; }

        [JsonProperty("member_rating", NullValueHandling = NullValueHandling.Ignore)]
        public int MemberRating { get; set; }

        [JsonProperty("last_changed", NullValueHandling = NullValueHandling.Ignore)]
        public string LastChanged { get; set; }

        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        [JsonProperty("vip", NullValueHandling = NullValueHandling.Ignore)]
        public bool Vip { get; set; }

        [JsonProperty("email_client", NullValueHandling = NullValueHandling.Ignore)]
        public string EmailClient { get; set; }

        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public Location Location { get; }

        [JsonProperty("last_note", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<object> Notes { get; set; }

        [JsonProperty("list_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ListId { get; set; }

        [JsonProperty("_links", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<Link> Links { get; set; }
    }
}

