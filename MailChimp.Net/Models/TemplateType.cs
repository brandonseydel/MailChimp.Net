using System.ComponentModel;

namespace MailChimp.Net.Models;

public enum TemplateType
{
    [Description("user")]
    User,
    [Description("base")]
    Base,
    [Description("gallery")]
    Gallery
}