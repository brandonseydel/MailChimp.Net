using System.Collections.Generic;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core;

public class SmsCampaignResponse : BaseResponse
{
    public SmsCampaignResponse()
    {
        SmsCampaigns = new HashSet<SmsCampaign>();
    }

    [MailChimpJsonProperty("sms_campaigns")]
    public IEnumerable<SmsCampaign> SmsCampaigns { get; set; }
}
