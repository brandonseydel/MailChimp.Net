using System.ComponentModel;

namespace MailChimp.Net.Models
{
    public enum Status
    {
        [Description("subscribed")]
        Subscribed,
        [Description("unsubscribed")]
        Unsubscribed,
        [Description("cleaned")]
        Cleaned,
        [Description("pending")]
        Pending
    }
}