using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

public class Capsule
{
    [MailChimpJsonProperty("notes")]
    public bool UpdateNotesForCampaign { get; set; }
}