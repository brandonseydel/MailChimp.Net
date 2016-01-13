using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class EmailResponse : BaseResponse
    {
        public EmailResponse()
        {
            EmailActivities = new HashSet<EmailActivity>();
        }

        [JsonProperty("emails")]
        public IEnumerable<EmailActivity> EmailActivities { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

    }
}