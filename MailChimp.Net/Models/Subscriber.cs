// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Subscriber.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

/// <summary>
/// The subscriber.
/// </summary>
public class Subscriber
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Subscriber"/> class.
    /// </summary>
    public Subscriber()
    {
        Links = new HashSet<Link>();
    }

    /// <summary>
    /// Gets or sets the email address.
    /// </summary>
    [MailChimpJsonProperty("email_address")]
    public string EmailAddress { get; set; }

    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    [MailChimpJsonProperty("id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }

    /// <summary>
    /// Gets or sets the list id.
    /// </summary>
    [MailChimpJsonProperty("list_id")]
    public string ListId { get; set; }

    /// <summary>
    /// Gets or sets the workflow id.
    /// </summary>
    [MailChimpJsonProperty("workflow_id")]
    public string WorkflowId { get; set; }
}