// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmailActivity.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Diagnostics;
using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The email activity.
    /// </summary>
    public class EmailActivity : Base
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailActivity"/> class.
        /// </summary>
        public EmailActivity()
        {
            Activity = new HashSet<MemberActivity>();
            Links = new HashSet<Link>();
        }

        /// <summary>
        /// Gets or sets the activity.
        /// </summary>
        [JsonProperty("activity")]
        public IEnumerable<MemberActivity> Activity { get; set; }

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

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Data.Add(EmailAddress)
                ;
        }
    }
}