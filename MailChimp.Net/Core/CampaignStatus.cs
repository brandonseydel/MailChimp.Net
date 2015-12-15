using System.ComponentModel;

namespace MailChimp.Net.Core
{
    public enum CampaignStatus
    {
        [Description("save")]
        Save,
        [Description("paused")]
        Paused,
        [Description("schedule")]
        Schedule,
        [Description("sending")]
        Sending,
        [Description("sent")]
        Sent
    }
}