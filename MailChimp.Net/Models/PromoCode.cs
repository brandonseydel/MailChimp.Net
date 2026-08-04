using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class PromoCode
{
    [MailChimpJsonProperty("id")]
    public string Id { get; set; }

    [MailChimpJsonProperty("code")]
    public string Code { get; set; }

    [MailChimpJsonProperty("redemption_url")]
    public string RedemptionUrl { get; set; }

}
