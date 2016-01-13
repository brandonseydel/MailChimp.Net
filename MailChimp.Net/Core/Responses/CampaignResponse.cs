using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class CampaignResponse : BaseResponse
    {

        [JsonProperty("campaigns")]
        public IEnumerable<Campaign> Campaigns { get; set; }
    }

}
