using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

public class ListLocation
{
    [MailChimpJsonProperty("country")]
    public string Country { get; set; }

    [MailChimpJsonProperty("cc")]
    public string CountryCode { get; set; }

    [MailChimpJsonProperty("percent")]
    public double Percent { get; set; }

    [MailChimpJsonProperty("total")]
    public int Total { get; set; }
}
