// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Twitter.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

/// <summary>
/// The twitter.
/// </summary>
public class Twitter
{
    /// <summary>
    /// Gets or sets the first tweet.
    /// </summary>
    [MailChimpJsonProperty("first_tweet")]
    public string FirstTweet { get; set; }

    /// <summary>
    /// Gets or sets the last tweet.
    /// </summary>
    [MailChimpJsonProperty("last_tweet")]
    public string LastTweet { get; set; }

    /// <summary>
    /// Gets or sets the retweets.
    /// </summary>
    [MailChimpJsonProperty("retweets")]
    public int Retweets { get; set; }

    /// <summary>
    /// Gets or sets the statuses.
    /// </summary>
    [MailChimpJsonProperty("retweets")]
    public IEnumerable<Status> Statuses { get; set; }

    /// <summary>
    /// Gets or sets the tweets.
    /// </summary>
    [MailChimpJsonProperty("tweets")]
    public int Tweets { get; set; }
}