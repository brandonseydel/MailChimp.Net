// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Location.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

	/// <summary>
	/// The location.
	/// </summary>
	public class Location
	{
		public Location()
		{
			CountryCode = string.Empty;
			Timezone = string.Empty;
		}
		/// <summary>
		/// Gets or sets the country code.
		/// </summary>
		[MailChimpJsonProperty("country_code")]
		public string CountryCode { get; set; }

		/// <summary>
		/// Gets or sets the dstoff.
		/// </summary>
		[MailChimpJsonProperty("dstoff")]
		public int Dstoff { get; set; }

		/// <summary>
		/// Gets or sets the gmtoff.
		/// </summary>
		[MailChimpJsonProperty("gmtoff")]
		public int Gmtoff { get; set; }

		/// <summary>
		/// Gets or sets the latitude.
		/// </summary>
		[MailChimpJsonProperty("latitude")]
		public decimal Latitude { get; set; }

		/// <summary>
		/// Gets or sets the longitude.
		/// </summary>
		[MailChimpJsonProperty("longitude")]
		public decimal Longitude { get; set; }

		/// <summary>
		/// Gets or sets the timezone.
		/// </summary>
		[MailChimpJsonProperty("timezone")]
		public string Timezone { get; set; }
	}