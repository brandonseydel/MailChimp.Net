using System.ComponentModel;

namespace MailChimp.Net.Models
{
    public enum Match
    {
        [Description("any")]
        Any,
        [Description("all")]
        All
    }
}