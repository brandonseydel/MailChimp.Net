using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

public class CustomerJourneyTriggerRequest
{
    [MailChimpJsonProperty("email_address")]
    public string EmailAddress { get; set; }
}
