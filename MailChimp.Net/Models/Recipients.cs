// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Recipients.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The recipient.
/// </summary>
public class Recipient
{
    /// <summary>
    /// Gets or sets the list id.
    /// </summary>
    [MailChimpJsonProperty("list_id")]
    public string ListId { get; set; }

    /// <summary>
    /// Gets or sets the segment text.
    /// </summary>
    [MailChimpJsonProperty("segment_text")]
    public string SegmentText { get; set; }

    /// <summary>
		/// Gets or sets the segment options.
		/// </summary>
		[MailChimpJsonProperty("segment_opts")]
    public SegmentOptions SegmentOptions { get; set; }
    
    /// <summary>
    /// Gets or sets the list name.
    /// </summary>
    [MailChimpJsonProperty("list_name")]
    public string ListName { get; set; }
    
    /// <summary>
    /// Gets or sets the list is active flag.
    /// </summary>
    [MailChimpJsonProperty("list_is_active")]
    public bool ListIsActive { get; set; }
    
    /// <summary>
    /// Gets or sets the recipient count.
    /// </summary>
    [MailChimpJsonProperty("recipient_count")]
    public int RecipientCount { get; set; }
}
