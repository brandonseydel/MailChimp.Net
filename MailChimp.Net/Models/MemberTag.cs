// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Member.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Core;

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
	/// <summary>
	/// The tag for a member
	/// </summary>
	public class MemberTag
	{
		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		[JsonProperty("id")]
		public int Id { get; set; }

		/// <summary>
		/// Gets or sets the tag's name.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }
	}
}
