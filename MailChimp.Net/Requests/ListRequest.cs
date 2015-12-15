using System;
using MailChimp.Net.Core;
using Newtonsoft.Json;

namespace MailChimp.Net.Requests
{
    public class ListRequest : BaseRequest
    {

        public ListRequest()
        {
        }

        [QueryString("count")]
        public int Limit { get; set; }
        [QueryString("offset")]
        public int Offset { get; set; }

        [QueryString("fields")]
        public string FieldsToInclude { get; set; }
        [QueryString("exclude_fields")]
        public string FieldsToExclude { get; set; }

        [QueryString("before_date_created")]
        public DateTime? CreatedBefore { get; set; }
        [QueryString("before_campaign_last_sent")]
        public DateTime? CampaignSentBefore { get; set; }
        [QueryString("since_campaign_last_sent")]
        public DateTime? CampaignSentSince { get; set; }
        [QueryString("since_date_created")]
        public DateTime? CreatedSince { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}