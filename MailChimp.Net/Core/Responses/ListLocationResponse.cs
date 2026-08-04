using System.Collections.Generic;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core;

public class ListLocationResponse : BaseResponse
{
    public ListLocationResponse()
    {
        Locations = new HashSet<ListLocation>();
    }

    [MailChimpJsonProperty("locations")]
    public IEnumerable<ListLocation> Locations { get; set; }

    [MailChimpJsonProperty("list_id")]
    public string ListId { get; set; }
}
