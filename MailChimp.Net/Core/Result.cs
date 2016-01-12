using System.ComponentModel;

namespace MailChimp.Net.Core
{
    public enum Result
    {
        [Description("success")] Success,
        [Description("warning")] Warning,
        [Description("error")] Error
    }
}