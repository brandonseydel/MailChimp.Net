using System;
using System.Collections.Generic;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class FileManagerFolder
{

    public FileManagerFolder()
    {
        Links = new HashSet<Link>();
    }

    [MailChimpJsonProperty("id")]
    public int Id { get; set; }

    [MailChimpJsonProperty("name")]
    public string Name { get; set; }

    [MailChimpJsonProperty("file_count")]
    public int FileCount { get; set; }

    [MailChimpJsonProperty("created_at")]
    public DateTime? CreatedAt { get; set; }

    [MailChimpJsonProperty("created_by")]
    public string CreatedBy { get; set; }

    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }
}
