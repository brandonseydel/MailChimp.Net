using System;
using System.ComponentModel;

namespace MailChimp.Net.Core
{
    [Flags]
    public enum CampaignStatus
    {
        [Description("save")]
        Save = 1,
        [Description("paused")]
        Paused = 2,
        [Description("schedule")]
        Schedule = 4,
        [Description("sending")]
        Sending = 8,
        [Description("sent")]
        Sent = 16
    }
}