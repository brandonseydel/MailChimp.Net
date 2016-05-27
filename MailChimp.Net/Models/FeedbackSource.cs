using System.ComponentModel;

namespace MailChimp.Net.Models
{
    public enum FeedbackSource
    {
        [Description("api")]
        Api,
        [Description("email")]
        Email,
        [Description("sms")]
        Sms,
        [Description("web")]
        Web,
        [Description("ios")]
        Ios,
        [Description("android")]
        Android
    }
}