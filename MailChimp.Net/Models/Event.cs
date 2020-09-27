﻿using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Event
    {
        [JsonProperty("subscribe")]
        public bool Subscribe { get; set; }

        [JsonProperty("unsubscribe")]
        public bool Unsubscribe { get; set; }

        [JsonProperty("profile")]
        public bool Profile { get; set; }

        [JsonProperty("cleaned")]
        public bool Cleaned { get; set; }

        [JsonProperty("upemail")]
        public bool Upemail { get; set; }

        [JsonProperty("campaign")]
        public bool Campaign { get; set; }
    }
}
