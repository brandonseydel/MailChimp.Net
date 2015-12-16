using System;
using System.ComponentModel;

namespace MailChimp.Net.Core
{
    [Flags]
    public enum CampaignType
    {        
        [Description("regular")]
        Regular = 1,
        [Description("plaintext")]
        Plaintext = 2,
        [Description("absplit")]
        Absplit = 4,
        [Description("rss")]
        Rss = 8,
        [Description("variate")]
        Variate = 16
    }
}