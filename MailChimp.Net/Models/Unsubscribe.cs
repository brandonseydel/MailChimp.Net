// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Unsubscribe.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The unsubscribe.
    /// </summary>
    public class Unsubscribe
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Unsubscribe"/> class.
        /// </summary>
        public Unsubscribe()
        {
            this.Links = new HashSet<Link>();
        }

        /// <summary>
        /// Gets or sets the campaign id.
        /// </summary>
        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the email id.
        /// </summary>
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        /// <summary>
        /// Gets or sets the links.
        /// </summary>
        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }

        /// <summary>
        /// Gets or sets the list id.
        /// </summary>
        [JsonProperty("list_id")]
        public string ListId { get; set; }

        /// <summary>
        /// Gets or sets the reason.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets the timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }
}