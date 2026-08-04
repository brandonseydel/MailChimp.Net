using System.Collections.Generic;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core;

public class AccountExportResponse : BaseResponse
{
    public AccountExportResponse()
    {
        Exports = new HashSet<AccountExport>();
    }

    [MailChimpJsonProperty("exports")]
    public IEnumerable<AccountExport> Exports { get; set; }
}
