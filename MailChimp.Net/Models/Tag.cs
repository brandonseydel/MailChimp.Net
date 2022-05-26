// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Tag.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Diagnostics;
using MailChimp.Net.Core;

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
	/// <summary>
	/// The tag for a member
	/// This one differs from the MemberTag model because it has status field and no id field.
	/// This is the format expected by MailChimp's API for managing member tags.
	/// </summary>
	public class Tag : Base
	{
		/// <summary>
		/// Gets or sets the tag's name.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

        /// <summary>
        /// Gets or sets the tag's status(active/inactive).
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Data.Add(Name)
                .Status.Add(Status)
                ;
        }

    }

    /// <summary>
    /// We need this only for the serialization purpose, to wrap the list of type Tag into a list with JsonPropery "tags"
    /// expected format: {tags: [{name: "tagName1", status: "active"}, {name: "tagName2", status: "inactive"}]}
    /// </summary>
    public class Tags
    {
        public Tags()
        {
            MemberTags = new List<Tag>();
        }

        [JsonProperty("tags")]
        public List<Tag> MemberTags { get; set; }
    }
}
