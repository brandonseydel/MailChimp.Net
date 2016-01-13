using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class AutomationResponse : BaseResponse
    {
        public AutomationResponse()
        {
            Automations = new HashSet<Automation>();
        }
        [JsonProperty("automations")]
        public IEnumerable<Automation> Automations { get; set; }

    }
}