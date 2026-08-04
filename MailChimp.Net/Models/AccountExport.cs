using System.Collections.Generic;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class AccountExport
{
    public AccountExport()
    {
        Links = new HashSet<Link>();
    }

    [MailChimpJsonProperty("export_id")]
    public int ExportId { get; set; }

    [MailChimpJsonProperty("started")]
    public string Started { get; set; }

    [MailChimpJsonProperty("finished")]
    public string Finished { get; set; }

    [MailChimpJsonProperty("size_in_bytes")]
    public long SizeInBytes { get; set; }

    [MailChimpJsonProperty("download_url")]
    public string DownloadUrl { get; set; }

    [MailChimpJsonProperty("includes")]
    public IEnumerable<string> Includes { get; set; }

    [MailChimpJsonProperty("since")]
    public string Since { get; set; }

    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }
}
