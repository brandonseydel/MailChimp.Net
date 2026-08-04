using MailChimp.Net.Models;
using System.Collections.Generic;

namespace MailChimp.Net.Core;

public class ECommerceResponse : BaseResponse
{

    [MailChimpJsonProperty("stores")]
    public IEnumerable<Store> Stores { get; set; }
}
