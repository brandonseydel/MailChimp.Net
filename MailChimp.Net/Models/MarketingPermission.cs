using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

public class MarketingPermission
{
    /// <summary>
    /// Gets or sets the the id for the marketing permission on the list.
    /// </summary>
    [MailChimpJsonProperty("marketing_permission_id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the text permission.
    /// </summary>
    [MailChimpJsonProperty("text")]
    public string Text { get; set; }

    /// <summary>
    /// Gets or sets if the subscriber has opted-in to the marketing permission.
    /// </summary>
    [MailChimpJsonProperty("enabled")]
    public bool Enabled { get; set; }
}
