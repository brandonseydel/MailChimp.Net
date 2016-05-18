// --------------------------------------------------------------------------------------------------------------------
// <copyright file="List.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
	/// <summary>
	/// The list.
	/// </summary>
	public class List
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="List"/> class.
		/// </summary>
		public List()
		{
			Visibility = "prv";
		}

		/// <summary>
		/// Gets or sets the beamer address.
		/// </summary>
		[JsonProperty("beamer_address", NullValueHandling = NullValueHandling.Ignore)]
		public string BeamerAddress { get; set; }

		/// <summary>
		/// Gets or sets the campaign defaults.
		/// </summary>
		[JsonProperty("campaign_defaults")]
		public CampaignDefaults CampaignDefaults { get; set; }

		/// <summary>
		/// Gets or sets the contact.
		/// </summary>
		[JsonProperty("contact")]
		public Contact Contact { get; set; }

		/// <summary>
		/// Gets or sets the date created.
		/// </summary>
		[JsonProperty("date_created", NullValueHandling = NullValueHandling.Ignore)]
		public string DateCreated { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether email type option.
		/// </summary>
		[JsonProperty("email_type_option")]
		public bool EmailTypeOption { get; set; }

		/// <summary>
		/// Gets or sets the id.
		/// </summary>
		[JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
		public string Id { get; set; }

		/// <summary>
		/// Gets or sets the links.
		/// </summary>
		[JsonProperty("_links", NullValueHandling = NullValueHandling.Ignore)]
		public IEnumerable<Link> Links { get; set; }

		/// <summary>
		/// Gets or sets the list rating.
		/// </summary>
		[JsonProperty("list_rating", NullValueHandling = NullValueHandling.Ignore)]
		public int ListRating { get; set; }

		/// <summary>
		/// Gets or sets the modules.
		/// </summary>
		[JsonProperty("modules", NullValueHandling = NullValueHandling.Ignore)]
		public object[] Modules { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the notify on subscribe.
		/// </summary>
		[JsonProperty("notify_on_subscribe", NullValueHandling = NullValueHandling.Ignore)]
		public string NotifyOnSubscribe { get; set; }

		/// <summary>
		/// Gets or sets the notify on unsubscribe.
		/// </summary>
		[JsonProperty("notify_on_unsubscribe", NullValueHandling = NullValueHandling.Ignore)]
		public string NotifyOnUnsubscribe { get; set; }

		/// <summary>
		/// Gets or sets the permission reminder.
		/// </summary>
		[JsonProperty("permission_reminder")]
		public string PermissionReminder { get; set; }

		/// <summary>
		/// Gets or sets the stats.
		/// </summary>
		[JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
		public Stats Stats { get; set; }

		/// <summary>
		/// Gets or sets the subscribe url long.
		/// </summary>
		[JsonProperty("subscribe_url_long", NullValueHandling = NullValueHandling.Ignore)]
		public string SubscribeUrlLong { get; set; }

		/// <summary>
		/// Gets or sets the subscribe url short.
		/// </summary>
		[JsonProperty("subscribe_url_short", NullValueHandling = NullValueHandling.Ignore)]
		public string SubscribeUrlShort { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether use archive bar.
		/// </summary>
		[JsonProperty("use_archive_bar")]
		public bool UseArchiveBar { get; set; }

		/// <summary>
		/// Gets or sets the visibility.
		/// </summary>
		[JsonProperty("visibility")]
		public string Visibility { get; set; }
	}
}