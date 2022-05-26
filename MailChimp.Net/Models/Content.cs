// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Content.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Diagnostics;
using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The content.
    /// </summary>
    public class Content : Base
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
        public IEnumerable<Link> Links { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("variate_contents")]
        public IEnumerable<VariateContents> VariateContents { get; set; }

        /// <summary>
        /// Gets or sets the plain text.
        /// </summary>
        [JsonProperty("plain_text")]
        public string PlainText { get; set; }

        /// <summary>
        /// The Archive HTML for the campaign.
        /// </summary>
        [JsonProperty("archive_html")]
        public string ArchiveHtml { get; set; }
        
        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Data.Add(PlainText)
                ;
        }
    }
}