using System.Collections.Generic;
using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Twitter
    {
        public int Tweets { get; set; }

        [JsonProperty("first_tweet")]
        public string FirstTweet { get; set; }

        [JsonProperty("last_tweet")]
        public string LastTweet { get; set; }

        public int Retweets { get; set; }
        public IEnumerable<Status> Statuses { get; set; }
    }
}