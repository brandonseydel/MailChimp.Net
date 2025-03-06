// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Recipients.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The recipient.
    /// </summary>
    public class Recipient
    {
        /// <summary>
        /// Gets or sets the list id.
        /// </summary>
        [JsonProperty("list_id")]
        public string ListId { get; set; }

        /// <summary>
        /// Gets or sets the segment text.
        /// </summary>
        [JsonProperty("segment_text")]
        public string SegmentText { get; set; }

        /// <summary>
        /// Gets or sets the segment options.
        /// </summary>
        [JsonProperty("segment_opts")]
        public SegmentOptions SegmentOptions { get; set; }
    
        /// <summary>
        /// Gets or sets the list name.
        /// </summary>
        [JsonProperty("list_name")]
        public string ListName { get; set; }
    
        /// <summary>
        /// Gets or sets the list is active flag.
        /// </summary>
        [JsonProperty("list_is_active")]
        public bool ListIsActive { get; set; }
    
        /// <summary>
        /// Gets or sets the recipient count.
        /// </summary>
        [JsonProperty("recipient_count")]
        public int RecipientCount { get; set; }
    }
}
