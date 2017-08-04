// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Twitter.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The twitter.
    /// </summary>
    public class Twitter
    {
        /// <summary>
        /// Gets or sets the first tweet.
        /// </summary>
        [JsonProperty("first_tweet")]
        public string FirstTweet { get; set; }

        /// <summary>
        /// Gets or sets the last tweet.
        /// </summary>
        [JsonProperty("last_tweet")]
        public string LastTweet { get; set; }

        /// <summary>
        /// Gets or sets the retweets.
        /// </summary>
        [JsonProperty("retweets")]
        public int Retweets { get; set; }

        /// <summary>
        /// Gets or sets the statuses.
        /// </summary>
        [JsonProperty("retweets")]
        public IEnumerable<Status> Statuses { get; set; }

        /// <summary>
        /// Gets or sets the tweets.
        /// </summary>
        [JsonProperty("tweets")]
        public int Tweets { get; set; }
    }
}