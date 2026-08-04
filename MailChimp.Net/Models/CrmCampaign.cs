using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

public abstract class CrmCampaign
{
    [MailChimpJsonProperty("campaign")]
    public bool CreateCampaignInAccount { get; set; }

    [MailChimpJsonProperty("notes")]
    public bool UpdateNotesForCampaign { get; set; }
}