using MailChimp.Net.Models;
using System.Collections.Generic;

namespace MailChimp.Net.Core;

public class ListActivityResponse : BaseResponse
{
    public ListActivityResponse()
    {
        Activities = new List<ListActivity>();
    }
    [MailChimpJsonProperty("activity")]
    public IEnumerable<ListActivity> Activities { get; set; }

    [MailChimpJsonProperty("list_id")]
    public string ListId { get; set; }
}
