// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContentRequest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;

using MailChimp.Net.Models;

using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The content request.
    /// </summary>
    public class ContentRequest
    {
        /// <summary>
        /// Gets or sets the archive.
        /// </summary>
        public Archive Archive { get; set; }

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

        /// <summary>
        /// Gets or sets the template.
        /// </summary>
        public Template Template { get; set; }
    }
}