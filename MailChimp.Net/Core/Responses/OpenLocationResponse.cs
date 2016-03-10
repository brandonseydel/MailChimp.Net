// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OpenLocationResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The open location response.
    /// </summary>
    public class OpenLocationResponse : BaseResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenLocationResponse"/> class.
        /// </summary>
        public OpenLocationResponse()
        {
            this.Locations = new HashSet<OpenLocation>();
        }

        /// <summary>
        /// Gets or sets the campaign id.
        /// </summary>
        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// Gets or sets the locations.
        /// </summary>
        [JsonProperty("locations")]
        public IEnumerable<OpenLocation> Locations { get; set; }
    }
}