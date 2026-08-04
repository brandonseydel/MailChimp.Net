using System.Collections.Generic;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class AudienceContact
{
    public AudienceContact()
    {
        Links = new HashSet<Link>();
    }

    [MailChimpJsonProperty("contact_id")]
    public string ContactId { get; set; }

    [MailChimpJsonProperty("email")]
    public string Email { get; set; }

    [MailChimpJsonProperty("status")]
    public string Status { get; set; }

    [MailChimpJsonProperty("sms_phone_number")]
    public string SmsPhoneNumber { get; set; }

    [MailChimpJsonProperty("sms_subscription_status")]
    public string SmsSubscriptionStatus { get; set; }

    [MailChimpJsonProperty("consents_to_one_to_one_messaging")]
    public bool? ConsentsToOneToOneMessaging { get; set; }

    [MailChimpJsonProperty("merge_fields")]
    public Dictionary<string, object> MergeFields { get; set; }

    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }
}
