using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Note
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("note")]
        public string Body { get; set; }

        [JsonProperty("list_id")]
        public string ListId { get; set; }

        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("_links")]
        public Link[] Links { get; set; }
    }
}