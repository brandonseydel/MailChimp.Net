// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Member.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

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
    [MailChimpJsonProperty("email_address")]
    public string EmailAddress { get; set; }

    /// <summary>
    /// Source of the member
    /// </summary>
    [MailChimpJsonProperty("source")]
    public string Source { get; set; }

    /// <summary>
    /// The full name of the member
    /// </summary>
    [MailChimpJsonProperty("full_name")]
    public string FullName { get; set; }

    /// <summary>
    /// Gets or sets the contact id
    /// </summary>
    [MailChimpJsonProperty("contact_id")]
    public string ContactId { get; set; }

    /// <summary>
    /// Gets or sets the SMS phone number.
    /// </summary>
    [MailChimpJsonProperty("sms_phone_number")]
    public string SmsPhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets the SMS subscription status.
    /// </summary>
    [MailChimpJsonProperty("sms_subscription_status")]
    public string SmsSubscriptionStatus { get; set; }

    /// <summary>
    /// Gets or sets the email client.
    /// </summary>
    [MailChimpJsonProperty("email_client")]
		public string EmailClient { get; set; }

    /// <summary>
    /// Gets or sets the email type.
    /// </summary>
    [MailChimpJsonProperty("email_type")]
    public string EmailType { get; set; }

    /// <summary>
    /// Gets or sets the constents flag
    /// </summary>
    [MailChimpJsonProperty("consents_to_one_to_one_messaging")]
    public bool ConsentsToOneToOneMessaging { get; set; }

    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    [MailChimpJsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		/// Gets or sets the interests.
		/// </summary>
		[MailChimpJsonProperty("interests")]
		public Dictionary<string, bool> Interests { get; set; }

		/// <summary>
		/// Gets or sets the ip opt.
		/// </summary>
		[MailChimpJsonProperty("ip_opt")]
		public string IpOpt { get; set; }

		/// <summary>
		/// Gets or sets the ip signup.
		/// </summary>
		[MailChimpJsonProperty("ip_signup")]
		public string IpSignup { get; set; }

		/// <summary>
		/// Gets or sets the language.
		/// </summary>
		[MailChimpJsonProperty("language")]
		public string Language { get; set; }

		/// <summary>
		/// Gets or sets the last changed.
		/// </summary>
		[MailChimpJsonProperty("last_changed")]
		public string LastChanged { get; set; }

		/// <summary>
		/// Gets or sets the links.
		/// </summary>
		[MailChimpJsonProperty("_links")]
		public IEnumerable<Link> Links { get; set; }

		/// <summary>
		/// Gets or sets the list id.
		/// </summary>
		[MailChimpJsonProperty("list_id")]
		public string ListId { get; set; }

		/// <summary>
		/// Gets the location.
		/// </summary>
		[MailChimpJsonProperty("location")]
		public Location Location { get; set; }

		/// <summary>
		/// Gets or sets the marketing permissions.
		/// </summary>
		[MailChimpJsonProperty("marketing_permissions")]
		public IEnumerable<MarketingPermission> MarketingPermissions { get; set; }

		/// <summary>
		/// Gets or sets the member rating.
		/// </summary>
		[MailChimpJsonProperty("member_rating")]
		public int MemberRating { get; set; }

		/// <summary>
		/// Gets or sets the merge fields.
		/// </summary>
		[MailChimpJsonProperty("merge_fields")]
		public Dictionary<string, object> MergeFields { get; set; }

		/// <summary>
		/// Gets or sets the number of tags.
		/// </summary>
		[MailChimpJsonProperty("tags_count")]
		public int TagsCount { get; set; }

		/// <summary>
		/// Gets or sets the tags.
		/// </summary>
		[MailChimpJsonProperty("tags")]
    [MailChimpJsonConverter(MailChimpJsonConverterKind.MemberTagList)] // This converted is used to serialize the tag list to a simple array of strings for PUT/POST requests
		public List<MemberTag> Tags { get; set; }

		/// <summary>
		/// Gets or sets the last Note.
		/// </summary>
		[MailChimpJsonProperty("last_note")]
		public MemberLastNote LastNote { get; set; }

		/// <summary>
		/// Gets or sets the stats.
		/// </summary>
		[MailChimpJsonProperty("stats")]
		public MemberStats Stats { get; set; }

		/// <summary>
		/// Sets the member's status unless they are new.  Then you need to use the <see cref="StatusIfNew"/> property.  Default value is <see cref="Status.Undefined"/>  
		/// </summary>
		[MailChimpJsonProperty("status")]
		[MailChimpJsonConverter(MailChimpJsonConverterKind.StringEnumDescription)]
		public Status Status { get; set; }

		[MailChimpJsonProperty("status_if_new")]
		[MailChimpJsonConverter(MailChimpJsonConverterKind.StringEnumDescription)]
		public Status StatusIfNew { get; set; }

		[MailChimpJsonProperty("unsubscribe_reason")]
		public string UnsubscribeReason { get; set; }

		/// <summary>
		/// Gets or sets the timestamp opt.
		/// </summary>
		[MailChimpJsonProperty("timestamp_opt")]
		public string TimestampOpt { get; set; }

		/// <summary>
		/// Gets or sets the timestamp signup.
		/// </summary>
		[MailChimpJsonProperty("timestamp_signup")]
		public string TimestampSignup { get; set; }

		/// <summary>
		/// Gets or sets the unique email id.
		/// </summary>
		[MailChimpJsonProperty("unique_email_id")]
		public string UniqueEmailId { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether vip.
		/// </summary>
		[MailChimpJsonProperty("vip")]
		public bool Vip { get; set; }

    /// <summary>
    /// Gets the ID used in the Mailchimp web application. <para>View this member in your Mailchimp account at https://{dc}.admin.mailchimp.com/lists/members/view?id={web_id}.</para>
    /// </summary>
    [MailChimpJsonProperty("web_id")]
    public int WebId { get; set; }
}