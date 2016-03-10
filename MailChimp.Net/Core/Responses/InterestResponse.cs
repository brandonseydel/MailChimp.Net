// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InterestResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using MailChimp.Net.Models;

using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The interest response.
    /// </summary>
    public class InterestResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InterestResponse"/> class.
        /// </summary>
        public InterestResponse()
        {
            this.Links = new HashSet<Link>();
            this.Interests = new HashSet<Interest>();
        }

        /// <summary>
        /// Gets or sets the category id.
        /// </summary>
        [JsonProperty("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the interests.
        /// </summary>
        [JsonProperty("interests")]
        public IEnumerable<Interest> Interests { get; set; }

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