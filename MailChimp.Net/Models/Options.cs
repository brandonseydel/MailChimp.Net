using System.Collections.Generic;
using MailChimp.Net.Core;

namespace MailChimp.Net.Models;


public class Options
{
    public Options()
    {
        Choices = new HashSet<string>();
    }

    [MailChimpJsonProperty("size")]
    public int Size { get; set; }

    [MailChimpJsonProperty("default_country")]
    public int DefaultCountry { get; set; }

    [MailChimpJsonProperty("phone_format")]
    public string PhoneFormat { get; set; }

    [MailChimpJsonProperty("date_format")]
    public string DateFormat { get; set; }

    [MailChimpJsonProperty("choices")]
    public IEnumerable<string> Choices { get; set; }
}
