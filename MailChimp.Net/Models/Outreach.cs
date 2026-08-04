using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

public class Outreach
{
    [MailChimpJsonProperty("id")]
    public string Id { get; set; }
}