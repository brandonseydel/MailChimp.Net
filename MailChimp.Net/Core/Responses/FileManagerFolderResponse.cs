using System.Collections.Generic;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core;

public class FileManagerFolderResponse
{
    public FileManagerFolderResponse()
    {
        Folders = new HashSet<FileManagerFolder>();
        Links = new HashSet<Link>();
    }

    [MailChimpJsonProperty("folders")]
    public IEnumerable<FileManagerFolder> Folders { get; set; }

    [MailChimpJsonProperty("total_items")]
    public int TotalItems { get; set; }

    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }
}
