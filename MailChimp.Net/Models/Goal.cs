// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Goal.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The goal.
/// </summary>
public class Goal
{
    /// <summary>
    /// Gets or sets the data.
    /// </summary>
    [MailChimpJsonProperty("data")]
    public string Data { get; set; }

    /// <summary>
    /// Gets or sets the event.
    /// </summary>
    [MailChimpJsonProperty("event")]
    public string Event { get; set; }

    /// <summary>
    /// Gets or sets the goal id.
    /// </summary>
    [MailChimpJsonProperty("goal_id")]
    public int GoalId { get; set; }

    /// <summary>
    /// Gets or sets the last visited at.
    /// </summary>
    [MailChimpJsonProperty("last_visited_at")]
    public string LastVisitedAt { get; set; }
}