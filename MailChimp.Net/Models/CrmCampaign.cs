using Newtonsoft.Json;
using System.Diagnostics;

namespace MailChimp.Net.Models
{
    public abstract class CrmCampaign : Base
    {
        [JsonProperty("campaign")]
        public bool CreateCampaignInAccount { get; set; }

        [JsonProperty("notes")]
        public bool UpdateNotesForCampaign { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Status.AddFlag(CreateCampaignInAccount)
                .Status.AddFlag(UpdateNotesForCampaign)
                ;
        }
    }
}