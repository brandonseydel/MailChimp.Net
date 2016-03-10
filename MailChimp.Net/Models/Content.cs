// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Content.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The content.
    /// </summary>
    public class Content
    {
        /// <summary>
        /// Gets or sets the html.
        /// </summary>
        [JsonProperty("html")]
        public string Html { get; set; }

        /// <summary>
        /// Gets or sets the links.
        /// </summary>
        [JsonProperty("_links")]
        public Link[] Links { get; set; }

        /// <summary>
        /// Gets or sets the plain text.
        /// </summary>
        [JsonProperty("plain_text")]
        public string PlainText { get; set; }
    }
}