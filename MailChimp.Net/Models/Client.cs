// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Client.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The client.
/// </summary>
public class Client
{
    /// <summary>
    /// Gets or sets the client name.
    /// </summary>
    [MailChimpJsonProperty("client")]
    public string ClientName { get; set; }

    /// <summary>
    /// Gets or sets the list id.
    /// </summary>
    [MailChimpJsonProperty("list_id")]
    public string ListId { get; set; }

    /// <summary>
    /// Gets or sets the members.
    /// </summary>
    [MailChimpJsonProperty("members")]
    public int Members { get; set; }
}