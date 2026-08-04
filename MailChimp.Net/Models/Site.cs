using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class Site
{
    [MailChimpJsonProperty("foreign_id")]
    public string ForeignId { get; set; }

    [MailChimpJsonProperty("store_id")]
    public string StoreId { get; set; }

    [MailChimpJsonProperty("platform")]
    public string Platform { get; set; }

    [MailChimpJsonProperty("domain")]
    public string Domain { get; set; }

    [MailChimpJsonProperty("site_script")]
    public SiteScript SiteScript { get; set; }

    [MailChimpJsonProperty("created_at")]
    public DateTime CreatedAt { get; set; }

    [MailChimpJsonProperty("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [MailChimpJsonProperty("_links")]
    public List<Link> Links { get; set; }
}
