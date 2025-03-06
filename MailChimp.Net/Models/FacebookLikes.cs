// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FacebookLikes.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The facebook likes.
    /// </summary>
    public class FacebookLikes
    {
        /// <summary>
        /// Gets or sets the facebook like count.
        /// </summary>
        [JsonProperty("facebook_likes")]
        public int FacebookLikeCount { get; set; }

        /// <summary>
        /// Gets or sets the recipient likes.
        /// </summary>
        [JsonProperty("recipient_likes")]
        public int RecipientLikes { get; set; }

        /// <summary>
        /// Gets or sets the unique likes.
        /// </summary>
        [JsonProperty("unique_likes")]
        public int UniqueLikes { get; set; }
    }
}