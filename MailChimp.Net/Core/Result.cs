using System.ComponentModel;

namespace MailChimp.Net.Models
{
    public enum Result
    {
        [Description("success")] Success,
        [Description("warning")] Warning,
        [Description("error")] Error
    }
}