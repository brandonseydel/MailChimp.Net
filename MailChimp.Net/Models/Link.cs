// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Link.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

/// <summary>
/// The link.
/// </summary>
public class Link
{
    /// <summary>
    /// Gets or sets the href.
    /// </summary>
    [MailChimpJsonProperty("href")]
    public string Href { get; set; }

    /// <summary>
    /// Gets or sets the method.
    /// </summary>
    [MailChimpJsonProperty("method")]
    [MailChimpJsonConverter(MailChimpJsonConverterKind.StringEnumDescription)]
    public Method Method { get; set; }

    /// <summary>
    /// Gets or sets the rel.
    /// </summary>
    [MailChimpJsonProperty("rel")]
    public string Rel { get; set; }

    /// <summary>
    /// Gets or sets the schema.
    /// </summary>
    [MailChimpJsonProperty("schema")]
    public string Schema { get; set; }

    /// <summary>
    /// Gets or sets the target schema.
    /// </summary>
    [MailChimpJsonProperty("targetSchema")]
    public string TargetSchema { get; set; }
}