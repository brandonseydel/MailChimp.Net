using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core.Responses;

public class ListEventResponse : BaseResponse
{
    [JsonProperty("events")]
    public IEnumerable<ListEvent> Events { get; set; } = new List<ListEvent>();
}
