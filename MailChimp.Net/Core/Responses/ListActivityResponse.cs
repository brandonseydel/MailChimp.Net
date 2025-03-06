using MailChimp.Net.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MailChimp.Net.Core
{
    public class ListActivityResponse : BaseResponse
    {
        public ListActivityResponse()
        {
            Activities = new List<ListActivity>();
        }
        [JsonProperty("activity")]
        public IEnumerable<ListActivity> Activities { get; set; }

        [JsonProperty("list_id")]
        public string ListId { get; set; }
    }
}
