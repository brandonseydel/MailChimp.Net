// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Interest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The interest.
    /// </summary>
    public class Interest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Interest"/> class.
        /// </summary>
        public Interest()
        {
            Links = new HashSet<Link>();
        }

        /// <summary>
        /// Gets or sets the display order.
        /// </summary>
        [JsonProperty("display_order")]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the interest category id.
        /// </summary>
        [JsonProperty("category_id")]
        public string InterestCategoryId { get; set; }

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
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the subscriber count.
        /// </summary>
        [JsonProperty("subscriber_count")]
        public string SubscriberCount { get; set; }
    }
}