using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class ApiInfo
    {

        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("account_name")]
        public string AccountName { get; set; }

        [JsonProperty("contact")]
        public Contact Contact { get; set; }

        [JsonProperty("last_login")]
        public string LastLogin { get; set; }

        [JsonProperty("total_subscribers")]
        public int TotalSubscribers { get; set; }

        [JsonProperty("_links")]
        public Link[] Links { get; set; }
    }

}