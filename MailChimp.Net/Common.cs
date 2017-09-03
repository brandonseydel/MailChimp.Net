using MailChimp.Net.Core;
using MailChimp.Net.Models;
using System;
using System.Collections.Generic;

namespace MailChimp.Net
{
    public class Common
    {
        public static Dictionary<CampaignAction, Type> CampaignActionDictionary { get; } = new Dictionary<CampaignAction, Type>
        {
            { CampaignAction.Replicate, typeof(ReplicateResponse) }
        };

        public static int DefaultLimit = 1000;
    }
}

