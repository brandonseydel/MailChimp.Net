using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class EepUrlActivity
    {
        public Twitter Twitter { get; set; }
        public IEnumerable<Status> Statuses { get; set; } 
        public IEnumerable<EepClick> Clicks { get; set; }
        public IEnumerable<Referrer> Referrers { get; set; } 
    }

    public class Referrer
    {
        [JsonProperty("referrer")]
        public string Name { get; set; }
        public int Clicks { get; set; }
        [JsonProperty("first_click")]
        public string FirstClick { get; set; }
        [JsonProperty("last_click")]
        public string LastClick { get; set; }
    }

    public class EepClick
    {
        public int Clicks { get; set; }
        [JsonProperty("first_click")]
        public string FirstClick { get; set; }
        [JsonProperty("last_click")]
        public string LastClick { get; set; }
        public IEnumerable<EepLocation> Locations { get; set; }
    }

    public class EepLocation
    {
        public string Country { get; set; }
        public string Region { get; set; }
    }

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

    public class Status
    {
        [JsonProperty("status")]
        public string Name { get; set; }
        [JsonProperty("screen_name")]
        public string ScreenName { get; set; }
        [JsonProperty("status_id")]
        public string StatusId { get; set; }
        public string DateTime { get; set; }
        [JsonProperty("is_retweet")]
        public bool IsRetweet { get; set; }
    }
}
