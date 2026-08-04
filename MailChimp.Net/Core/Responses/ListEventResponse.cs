using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core.Responses;

public class ListEventResponse : BaseResponse
{
    [MailChimpJsonProperty("events")]
    public IEnumerable<ListEvent> Events { get; set; } = new List<ListEvent>();
}
