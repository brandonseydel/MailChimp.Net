using System;
using MailChimp.Net.Core;
using Newtonsoft.Json;

namespace MailChimp.Net.Requests
{
    public class CampaignRequest : BaseRequest
    {
        
        [QueryString("type")]
        public CampaignType Type { get; set; }
        [QueryString("status")]
        public CampaignStatus Status { get; set; }
    }
}