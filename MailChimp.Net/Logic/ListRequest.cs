using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MailChimp.Net.Logic
{
    public class ListRequest : BaseRequest
    {

        public ListRequest()
        {
            FieldsToExclude = new HashSet<string>();
            FieldsToInclude = new HashSet<string>();
        }
        public int Limit { get; set; }
        public int Offset { get; set; }

        public IEnumerable<string> FieldsToInclude { get; set; }
        public IEnumerable<string> FieldsToExclude { get; set; }

        public DateTime? CreatedBefore { get; set; }
        public DateTime? CampaignSentBefore { get; set; }
        public DateTime? CampaignSentSince { get; set; }
        public DateTime? CreatedSince { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        public override string ToQueryString()
        {
            return "";
        }
    }
}