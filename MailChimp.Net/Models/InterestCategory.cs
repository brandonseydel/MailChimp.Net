// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InterestCategory.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The interest category.
    /// </summary>
    public class InterestCategory
    {
        /// <summary>
        /// Gets or sets the display order.
        /// </summary>
        [JsonProperty("display_order")]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets the display type.
        /// </summary>
        [JsonProperty("type")]
        public string DisplayType { get; set; }

        /// <summary>
        /// Gets the id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; }

        /// <summary>
        /// Gets the list id.
        /// </summary>
        [JsonProperty("list_id")]
        public string ListId { get; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}