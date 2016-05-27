using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Net.Models
{
    public enum CampaignAction
    {
        [Description("cancel-send")]
        Cancel-Send,
        Pause,
        Replicate,
        Resume,
        Schedule,
        Send,
        Test,
        Unschedule
    }
}
