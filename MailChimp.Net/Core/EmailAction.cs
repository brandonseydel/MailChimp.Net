using System.ComponentModel;

namespace MailChimp.Net.Core;

/// <summary>
/// One of the following actions: ‘open’, ‘click’, or ‘bounce’
/// </summary>
public enum EmailAction
{
    [Description("")]
    None,
    [Description("open")]
    Open,
    [Description("click")]
    Click,
    [Description("bounce")]
    Bounce
}
