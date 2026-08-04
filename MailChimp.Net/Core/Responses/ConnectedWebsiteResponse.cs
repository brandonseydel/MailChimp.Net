using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core;

public class ConnectedWebsiteResponse
{
    [MailChimpJsonProperty("sites")]
    public IEnumerable<Site> Sites { get; set; } = new HashSet<Site>();

    [MailChimpJsonProperty("total_items")]
    public int TotalItems { get; set; }

    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; } = new HashSet<Link>();
}