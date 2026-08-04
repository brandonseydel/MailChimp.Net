// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Tag.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

	/// <summary>
	/// The tag for a member
	/// This one differs from the MemberTag model because it has status field and no id field.
	/// This is the format expected by MailChimp's API for managing member tags.
	/// </summary>
	public class Tag
	{
		/// <summary>
		/// Gets or sets the tag's name.
		/// </summary>
		[MailChimpJsonProperty("name")]
		public string Name { get; set; }

    /// <summary>
    /// Gets or sets the tag's status(active/inactive).
    /// </summary>
    [MailChimpJsonProperty("status")]
    public string Status { get; set; }

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

    [MailChimpJsonProperty("tags")]
    public List<Tag> MemberTags { get; set; }
}
