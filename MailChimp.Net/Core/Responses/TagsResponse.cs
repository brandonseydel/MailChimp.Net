// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TagsResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

namespace MailChimp.Net.Core;

	public class TagsResponse
	{
		public TagsResponse()
		{
			Tags = new List<MemberTag>();
		}

		/// <summary>
		/// Gets or sets the tags.
		/// </summary>
		[MailChimpJsonProperty("tags")]
		public IEnumerable<MemberTag> Tags { get; set; }

		/// <summary>
		/// Gets or sets the number of tags.
		/// </summary>
		[MailChimpJsonProperty("total_items")]
		public int NumberOfTags { get; set; }
	}
