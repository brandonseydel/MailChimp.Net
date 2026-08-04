using System.Collections.Generic;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core;

public class EcommerceProductActivityResponse : BaseResponse
{
    public EcommerceProductActivityResponse()
    {
        Products = new HashSet<EcommerceProductActivity>();
    }

    [MailChimpJsonProperty("products")]
    public IEnumerable<EcommerceProductActivity> Products { get; set; }

    [MailChimpJsonProperty("campaign_id")]
    public string CampaignId { get; set; }
}
