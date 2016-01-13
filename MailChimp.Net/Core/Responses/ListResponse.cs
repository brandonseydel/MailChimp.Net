using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    internal class ListResponse : BaseResponse
    {
        public ListResponse()
        {
            Lists = new HashSet<List>();
        }

        [JsonProperty("lists")]
        public IEnumerable<List> Lists { get; set; }

    }
}