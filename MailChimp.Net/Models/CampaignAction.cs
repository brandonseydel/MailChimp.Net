using System.ComponentModel;

namespace MailChimp.Net.Models;

public enum CampaignAction
{
    [Description("cancel-send")]
    CancelSend,
    [Description("pause")]
    Pause,
    [Description("replicate")]
    Replicate,
    [Description("resume")]
    Resume,
    [Description("schedule")]
    Schedule,
    [Description("send")]
    Send,
    [Description("test")]
    Test,
    [Description("unschedule")]
    Unschedule,
    [Description("create-resend")]
    CreateResend
}
