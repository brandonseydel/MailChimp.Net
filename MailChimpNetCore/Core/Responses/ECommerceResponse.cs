using MailChimp.Net.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MailChimp.Net.Core
{
    public class ECommerceResponse : BaseResponse
    {

        [JsonProperty("stores")]
        public IEnumerable<Store> Stores { get; set; }
    }
}
