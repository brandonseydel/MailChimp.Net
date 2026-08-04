using System.Collections.Generic;

using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

/// <summary>
/// </summary>
public class ContentTemplate
{
    /// <summary>
    /// </summary>
    [MailChimpJsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// </summary>
    [MailChimpJsonProperty("sections")]
    public Dictionary<string, object> Sections { get; set; }
}
