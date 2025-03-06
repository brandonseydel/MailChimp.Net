using System.ComponentModel;

namespace MailChimp.Net.Models
{
    public enum CampaignAction
    {
        [Description("cancel-send")]
        CancelSend,
        Pause,
        Replicate,
        Resume,
        Schedule,
        Send,
        Test,
        Unschedule
    }
}
