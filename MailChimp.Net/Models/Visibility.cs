using System.ComponentModel;

namespace MailChimp.Net.Models;

public enum Visibility
{
    [Description("pub")]
    Public,
    [Description("prv")]
    Private
}