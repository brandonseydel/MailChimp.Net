using Newtonsoft.Json;

namespace MailChimp.Net.Models;

public abstract class CrmCampaign
{
    [JsonProperty("campaign")]
    public bool CreateCampaignInAccount { get; set; }

    [JsonProperty("notes")]
    public bool UpdateNotesForCampaign { get; set; }
}