﻿// --------------------------------------------------------------------------------------------------------------------
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
			this.Links = new HashSet<Link>();
			BeamerAddress = string.Empty;
			DateCreated = string.Empty;
			Id = string.Empty;
			NotifyOnSubscribe = string.Empty;
			NotifyOnUnsubscribe = string.Empty;
			Stats = new Stats()
			{
				CampaignLastSent = string.Empty,
				LastSubDate = string.Empty,
				LastUnsubDate = string.Empty
			};
			SubscribeUrlLong = string.Empty;
			SubscribeUrlShort = string.Empty;
			Visibility = "prv";
		}

		/// <summary>
		/// Gets or sets the beamer address.
		/// </summary>
		[JsonProperty("beamer_address")]
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
		[JsonProperty("date_created")]
		public string DateCreated { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether email type option.
		/// </summary>
		[JsonProperty("email_type_option")]
		public bool EmailTypeOption { get; set; }

		/// <summary>
		/// Gets or sets the id.
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		/// Gets or sets the links.
		/// </summary>
		[JsonProperty("_links")]
		public IEnumerable<Link> Links { get; set; }

		/// <summary>
		/// Gets or sets the list rating.
		/// </summary>
		[JsonProperty("list_rating")]
		public int ListRating { get; set; }

		/// <summary>
		/// Gets or sets the modules.
		/// </summary>
		[JsonProperty("modules")]
		public object[] Modules { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the notify on subscribe.
		/// </summary>
		[JsonProperty("notify_on_subscribe")]
		public string NotifyOnSubscribe { get; set; }

		/// <summary>
		/// Gets or sets the notify on unsubscribe.
		/// </summary>
		[JsonProperty("notify_on_unsubscribe")]
		public string NotifyOnUnsubscribe { get; set; }

		/// <summary>
		/// Gets or sets the permission reminder.
		/// </summary>
		[JsonProperty("permission_reminder")]
		public string PermissionReminder { get; set; }

		/// <summary>
		/// Gets or sets the stats.
		/// </summary>
		[JsonProperty("stats")]
		public Stats Stats { get; set; }

		/// <summary>
		/// Gets or sets the subscribe url long.
		/// </summary>
		[JsonProperty("subscribe_url_long")]
		public string SubscribeUrlLong { get; set; }

		/// <summary>
		/// Gets or sets the subscribe url short.
		/// </summary>
		[JsonProperty("subscribe_url_short")]
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