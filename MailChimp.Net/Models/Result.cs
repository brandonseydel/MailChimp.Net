using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

public class Result
{
    [MailChimpJsonProperty("campaign")]
    public Campaign Campaign { get; set; }

    [MailChimpJsonProperty("snippet")]
    public string Snippet { get; set; }
}
