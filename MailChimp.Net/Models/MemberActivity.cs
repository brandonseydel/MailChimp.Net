using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// An array of objects, each showing an interaction with the email.
/// </summary>
public class MemberActivity
{
    /// <summary>
    /// One of the following actions: ‘open’, ‘click’, or ‘bounce’
    /// </summary>
    
    [MailChimpJsonConverter(MailChimpJsonConverterKind.StringEnumDescription)]
    public EmailAction? Action { get; set; }
    public string Type { get; set; }
    public string Timestamp { get; set; }
    public string Url { get; set; }
    public string Ip { get; set; }
}
