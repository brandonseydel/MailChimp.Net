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
		public Member()
		{
			MergeFields = new Dictionary<string, object>();
			MarketingPermissions = new List<MarketingPermission>();
			Links = new List<Link>();
			Interests = new Dictionary<string, bool>();
			Status = Status.Undefined;
			StatusIfNew = Status.Pending;
			Tags = new List<MemberTag>();
		}

		/// <summary>
		/// Gets or sets the email address.
		/// </summary>
		[JsonProperty("email_address")]
		public string EmailAddress { get; set; }

		/// <summary>
		/// Gets or sets the email client.
		/// </summary>
		[JsonProperty("email_client")]
		public string EmailClient { get; set; }

		/// <summary>
		/// Gets or sets the email type.
		/// </summary>
		[JsonProperty("email_type")]
		public string EmailType { get; set; }

		/// <summary>
		/// Gets or sets the id.
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		/// Gets or sets the interests.
		/// </summary>
		[JsonProperty("interests")]
		public Dictionary<string, bool> Interests { get; set; }

		/// <summary>
		/// Gets or sets the ip opt.
		/// </summary>
		[JsonProperty("ip_opt")]
		public string IpOpt { get; set; }

		/// <summary>
		/// Gets or sets the ip signup.
		/// </summary>
		[JsonProperty("ip_signup")]
		public string IpSignup { get; set; }

		/// <summary>
		/// Gets or sets the language.
		/// </summary>
		[JsonProperty("language")]
		public string Language { get; set; }

		/// <summary>
		/// Gets or sets the last changed.
		/// </summary>
		[JsonProperty("last_changed")]
		public string LastChanged { get; set; }

		/// <summary>
		/// Gets or sets the links.
		/// </summary>
		[JsonProperty("_links")]
		public IEnumerable<Link> Links { get; set; }

		/// <summary>
		/// Gets or sets the list id.
		/// </summary>
		[JsonProperty("list_id")]
		public string ListId { get; set; }

		/// <summary>
		/// Gets the location.
		/// </summary>
		[JsonProperty("location")]
		public Location Location { get; set; }

		/// <summary>
		/// Gets or sets the marketing permissions.
		/// </summary>
		[JsonProperty("marketing_permissions")]
		public IEnumerable<MarketingPermission> MarketingPermissions { get; set; }

		/// <summary>
		/// Gets or sets the member rating.
		/// </summary>
		[JsonProperty("member_rating")]
		public int MemberRating { get; set; }

		/// <summary>
		/// Gets or sets the merge fields.
		/// </summary>
		[JsonProperty("merge_fields")]
		public Dictionary<string, object> MergeFields { get; set; }

		/// <summary>
		/// Gets or sets the number of tags.
		/// </summary>
		[JsonProperty("tags_count")]
		public int TagsCount { get; set; }

		/// <summary>
		/// Gets or sets the tags.
		/// </summary>
		[JsonProperty("tags")]
        [JsonConverter(typeof(MemberTagListJsonConverter))] // This converted is used to serialize the tag list to a simple array of strings for PUT/POST requests
		public List<MemberTag> Tags { get; set; }

		/// <summary>
		/// Gets or sets the last Note.
		/// </summary>
		[JsonProperty("last_note")]
		public MemberLastNote LastNote { get; set; }

		/// <summary>
		/// Gets or sets the stats.
		/// </summary>
		[JsonProperty("stats")]
		public MemberStats Stats { get; set; }

		/// <summary>
		/// Sets the member's status unless they are new.  Then you need to use the <see cref="StatusIfNew"/> property.  Default value is <see cref="Status.Undefined"/>  
		/// </summary>
		[JsonProperty("status")]
		[JsonConverter(typeof(StringEnumDescriptionConverter))]
		public Status Status { get; set; }

		[JsonProperty("status_if_new")]
 		[JsonConverter(typeof(StringEnumDescriptionConverter))]
		public Status StatusIfNew { get; set; }

		[JsonProperty("unsubscribe_reason")]
		public string UnsubscribeReason { get; set; }

		/// <summary>
		/// Gets or sets the timestamp opt.
		/// </summary>
		[JsonProperty("timestamp_opt")]
		public string TimestampOpt { get; set; }

		/// <summary>
		/// Gets or sets the timestamp signup.
		/// </summary>
		[JsonProperty("timestamp_signup")]
		public string TimestampSignup { get; set; }

		/// <summary>
		/// Gets or sets the unique email id.
		/// </summary>
		[JsonProperty("unique_email_id")]
		public string UniqueEmailId { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether vip.
		/// </summary>
		[JsonProperty("vip")]
		public bool Vip { get; set; }
	}
}
