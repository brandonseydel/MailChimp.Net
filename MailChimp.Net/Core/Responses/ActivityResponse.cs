using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class ActivityResponse : BaseResponse
    {
        public ActivityResponse()
        {
            Activity = new HashSet<Activity>();
        }

        [JsonProperty("activity")]
        public IEnumerable<Activity> Activity { get; set; }

        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("list_id")]
        public string ListId { get; set; }

    }
}