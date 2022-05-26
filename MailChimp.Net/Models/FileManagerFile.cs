// --------------------------------------------------------------------------------------------------------------------
// <copyright file="File.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// <summary>
//   The file manager file.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using MailChimp.Net.Core;
using System.Diagnostics;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The file manager file.
    /// </summary>
    public class FileManagerFile : Base, IId<int>
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("folder_id")]
        public int FolderId { get; set; }

        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumDescriptionConverter))]
        public FileType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("full_size_url")]
        public string FullSizeUrl { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("_links")]
        public IList<Link> Links { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Id.Add(Id)
                .Type.Add(Type)
                .Data.Add(Name)
                .Postfix.Add(FullSizeUrl)
                ;
        }
    }

}
