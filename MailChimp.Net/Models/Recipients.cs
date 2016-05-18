// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Recipients.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
	/// <summary>
	/// The recipient.
	/// </summary>
	public class Recipient
	{
		/// <summary>
		/// Gets or sets the list id.
		/// </summary>
		[JsonProperty("list_id")]
		public string ListId { get; set; }

		/// <summary>
		/// Gets or sets the segment text.
		/// </summary>
		[JsonProperty("segment_text", NullValueHandling = NullValueHandling.Ignore)]
		public string SegmentText { get; set; }

		/// <summary>
		/// Gets or sets the segment options.
		/// </summary>
		[JsonProperty("segment_opts", NullValueHandling = NullValueHandling.Ignore)]
		public SegmentOptions SegmentOptions { get; set; }
    }
}