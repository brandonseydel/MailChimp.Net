// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Domain.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;
using System.Diagnostics;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The domain.
    /// </summary>
    public class Domain : Base
    {
        /// <summary>
        /// Gets or sets the bounces.
        /// </summary>
        [JsonProperty("bounces")]
        public int Bounces { get; set; }

        /// <summary>
        /// Gets or sets the bounces pct.
        /// </summary>
        [JsonProperty("bounces_pct")]
        public int BouncesPct { get; set; }

        /// <summary>
        /// Gets or sets the clicks.
        /// </summary>
        [JsonProperty("clicks")]
        public int Clicks { get; set; }

        /// <summary>
        /// Gets or sets the clicks pct.
        /// </summary>
        [JsonProperty("clicks_pct")]
        public int ClicksPct { get; set; }

        /// <summary>
        /// Gets or sets the delivered.
        /// </summary>
        [JsonProperty("delivered")]
        public int Delivered { get; set; }

        /// <summary>
        /// Gets or sets the domain name.
        /// </summary>
        [JsonProperty("domain")]
        public string DomainName { get; set; }

        /// <summary>
        /// Gets or sets the emails pct.
        /// </summary>
        [JsonProperty("emails_pct")]
        public int EmailsPct { get; set; }

        /// <summary>
        /// Gets or sets the emails sent.
        /// </summary>
        [JsonProperty("emails_sent")]
        public int EmailsSent { get; set; }

        /// <summary>
        /// Gets or sets the opens.
        /// </summary>
        [JsonProperty("opens")]
        public int Opens { get; set; }

        /// <summary>
        /// Gets or sets the opens pct.
        /// </summary>
        [JsonProperty("opens_pct")]
        public int OpensPct { get; set; }

        /// <summary>
        /// Gets or sets the unsubs.
        /// </summary>
        [JsonProperty("unsubs")]
        public int Unsubs { get; set; }

        /// <summary>
        /// Gets or sets the unsubs pct.
        /// </summary>
        [JsonProperty("unsubs_pct")]
        public int UnsubsPct { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Data.Add(DomainName)
                .Postfix.AddExpression(EmailsSent)
                ;
        }

    }
}