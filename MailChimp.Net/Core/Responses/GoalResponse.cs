using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class GoalResponse : BaseResponse
    {
        public GoalResponse()
        {
            Goals = new HashSet<Goal>();
        }
        [JsonProperty("goals")]
        public IEnumerable<Goal> Goals { get; set; }

        [JsonProperty("list_id")]
        public string ListId { get; set; }

        [JsonProperty("email_id")]
        public string EmailId { get; set; }

    }
}