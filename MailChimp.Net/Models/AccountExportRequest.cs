using System.Collections.Generic;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class AccountExportRequest
{
    [MailChimpJsonProperty("include_stages")]
    public IEnumerable<string> IncludeStages { get; set; }

    [MailChimpJsonProperty("since_timestamp")]
    public string SinceTimestamp { get; set; }
}
