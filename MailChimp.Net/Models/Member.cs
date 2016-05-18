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
	/// The member.
	/// </summary>
	public class Member
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Member"/> class.
		/// </summary>
		public Member()
		{
		}

		/// <summary>
		/// Gets or sets the email address.
		/// </summary>
		[JsonProperty("email_address")]
		public string EmailAddress { get; set; }

		/// <summary>
		/// Gets or sets the email client.
		/// </summary>
		[JsonProperty("email_client", NullValueHandling = NullValueHandling.Ignore)]
		public string EmailClient { get; set; }

		/// <summary>
		/// Gets or sets the email type.
		/// </summary>
		[JsonProperty("email_type", NullValueHandling = NullValueHandling.Ignore)]
		public string EmailType { get; set; }

		/// <summary>
		/// Gets or sets the id.
		/// </summary>
		[JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
		public string Id { get; set; }

		/// <summary>
		/// Gets or sets the interests.
		/// </summary>
		[JsonProperty("interests", NullValueHandling = NullValueHandling.Ignore)]
		public Dictionary<string, bool> Interests { get; set; }

		/// <summary>
		/// Gets or sets the ip opt.
		/// </summary>
		[JsonProperty("ip_opt", NullValueHandling = NullValueHandling.Ignore)]
		public string IpOpt { get; set; }

		/// <summary>
		/// Gets or sets the ip signup.
		/// </summary>
		[JsonProperty("ip_signup", NullValueHandling = NullValueHandling.Ignore)]
		public string IpSignup { get; set; }

		/// <summary>
		/// Gets or sets the language.
		/// </summary>
		[JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
		public string Language { get; set; }

		/// <summary>
		/// Gets or sets the last changed.
		/// </summary>
		[JsonProperty("last_changed", NullValueHandling = NullValueHandling.Ignore)]
		public string LastChanged { get; set; }

		/// <summary>
		/// Gets or sets the links.
		/// </summary>
		[JsonProperty("_links", NullValueHandling = NullValueHandling.Ignore)]
		public IEnumerable<Link> Links { get; set; }

		/// <summary>
		/// Gets or sets the list id.
		/// </summary>
		[JsonProperty("list_id", NullValueHandling = NullValueHandling.Ignore)]
		public string ListId { get; set; }

		/// <summary>
		/// Gets the location.
		/// </summary>
		[JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
		public Location Location { get; set; }

		/// <summary>
		/// Gets or sets the member rating.
		/// </summary>
		[JsonProperty("member_rating", NullValueHandling = NullValueHandling.Ignore)]
		public int MemberRating { get; set; }

		/// <summary>
		/// Gets or sets the merge fields.
		/// </summary>
		[JsonProperty("merge_fields", NullValueHandling = NullValueHandling.Ignore)]
		public Dictionary<string, string> MergeFields { get; set; }

		/// <summary>
		/// Gets or sets the last Note.
		/// </summary>
		[JsonProperty("last_note", NullValueHandling = NullValueHandling.Ignore)]
		public MemberLastNote LastNote { get; set; }

		/// <summary>
		/// Gets or sets the stats.
		/// </summary>
		[JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
		public Stats Stats { get; set; }

		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		[JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(StringEnumDescriptionConverter))]
		public Status Status { get; set; }

		/// <summary>
		/// Gets or sets the status for a new contact when using PUT.
		/// </summary>
		[JsonProperty("status_if_new", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(StringEnumDescriptionConverter))]
		public Status StatusIfNew { get; set; }

		/// <summary>
		/// Gets or sets the timestamp opt.
		/// </summary>
		[JsonProperty("timestamp_opt", NullValueHandling = NullValueHandling.Ignore)]
		public string TimestampOpt { get; set; }

		/// <summary>
		/// Gets or sets the timestamp signup.
		/// </summary>
		[JsonProperty("timestamp_signup", NullValueHandling = NullValueHandling.Ignore)]
		public string TimestampSignup { get; set; }

		/// <summary>
		/// Gets or sets the unique email id.
		/// </summary>
		[JsonProperty("unique_email_id", NullValueHandling = NullValueHandling.Ignore)]
		public string UniqueEmailId { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether vip.
		/// </summary>
		[JsonProperty("vip")]
		public bool Vip { get; set; }
	}
}