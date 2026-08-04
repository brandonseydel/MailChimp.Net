// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FacebookLikes.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The facebook likes.
/// </summary>
public class FacebookLikes
{
    /// <summary>
    /// Gets or sets the facebook like count.
    /// </summary>
    [MailChimpJsonProperty("facebook_likes")]
    public int FacebookLikeCount { get; set; }

    /// <summary>
    /// Gets or sets the recipient likes.
    /// </summary>
    [MailChimpJsonProperty("recipient_likes")]
    public int RecipientLikes { get; set; }

    /// <summary>
    /// Gets or sets the unique likes.
    /// </summary>
    [MailChimpJsonProperty("unique_likes")]
    public int UniqueLikes { get; set; }
}