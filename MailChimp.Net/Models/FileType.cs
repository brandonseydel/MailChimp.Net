using System.ComponentModel;

namespace MailChimp.Net.Models;

public enum FileType
{
    [Description("image")]
    Image,
    [Description("file")]
    File
}