// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Location.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;
using System.Diagnostics;

namespace MailChimp.Net.Models
{
	/// <summary>
	/// The location.
	/// </summary>
	public class Location : Base
	{
		public Location()
		{
			CountryCode = string.Empty;
			Timezone = string.Empty;
		}
		/// <summary>
		/// Gets or sets the country code.
		/// </summary>
		[JsonProperty("country_code")]
		public string CountryCode { get; set; }

		/// <summary>
		/// Gets or sets the dstoff.
		/// </summary>
		[JsonProperty("dstoff")]
		public int Dstoff { get; set; }

		/// <summary>
		/// Gets or sets the gmtoff.
		/// </summary>
		[JsonProperty("gmtoff")]
		public int Gmtoff { get; set; }

		/// <summary>
		/// Gets or sets the latitude.
		/// </summary>
		[JsonProperty("latitude")]
		public decimal Latitude { get; set; }

		/// <summary>
		/// Gets or sets the longitude.
		/// </summary>
		[JsonProperty("longitude")]
		public decimal Longitude { get; set; }

		/// <summary>
		/// Gets or sets the timezone.
		/// </summary>
		[JsonProperty("timezone")]
		public string Timezone { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Data.Add(Timezone)
                .Postfix.Add(CountryCode)
                ;
        }
    }
}