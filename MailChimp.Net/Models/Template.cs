// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Template.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using Newtonsoft.Json;
using MailChimp.Net.Core;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The template.
    /// </summary>
    public class Template
    {
        /// <summary>
        /// Gets or sets a value indicating whether active.
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the created by.
        /// </summary>
        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the date created.
        /// </summary>
        [JsonProperty("date_created")]
        public string DateCreated { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether drag and drop.
        /// </summary>
        [JsonProperty("drag_and_drop")]
        public bool DragAndDrop { get; set; }

        /// <summary>
        /// Gets or sets the folder id.
        /// </summary>
        [JsonProperty("folder_id")]
        public int FolderId { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the links.
        /// </summary>
        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether responsive.
        /// </summary>
        [JsonProperty("responsive")]
        public bool Responsive { get; set; }

        /// <summary>
        /// Gets or sets the share url.
        /// </summary>
        [JsonProperty("share_url")]
        public string ShareUrl { get; set; }

        /// <summary>
        /// Gets or sets the thumbnail.
        /// </summary>
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumDescriptionConverter))]
        public TemplateType Type { get; set; }
    }
}