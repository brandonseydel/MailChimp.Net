// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AbuseReportResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The abuse report response.
    /// </summary>
    public class AbuseReportResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbuseReportResponse"/> class.
        /// </summary>
        public AbuseReportResponse()
        {
            this.AbuseReports = new HashSet<AbuseReport>();
            this.Links = new HashSet<Link>();
        }

        /// <summary>
        /// Gets or sets the abuse reports.
        /// </summary>
        [JsonProperty("abuse_reports")]
        public IEnumerable<AbuseReport> AbuseReports { get; set; }

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
        /// Gets or sets the total items.
        /// </summary>
        [JsonProperty("total_items")]
        public int TotalItems { get; set; }
    }
}