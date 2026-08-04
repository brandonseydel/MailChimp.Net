using System.Collections.Generic;
using MailChimp.Net.Models;

namespace MailChimp.Net.Core;

public class FileManagerFileResponse : BaseResponse
{

    public FileManagerFileResponse()
    {
        Files = new HashSet<FileManagerFile>();
    }

    [MailChimpJsonProperty("files")]
    public IEnumerable<FileManagerFile> Files { get; set; }

    [MailChimpJsonProperty("total_file_size")]
    public int TotalFileSize { get; set; }
}
