using System.ComponentModel;

namespace MailChimp.Net.Models;

public enum AutomationStatus
{
    [Description("save")]
    Save,
    [Description("paused")]
    Paused,
    [Description("sending")]
    Sending,
    [Description("archived")]
    Archived
}