using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class SiteScript
{
    [MailChimpJsonProperty("url")]
    public string Url { get; set; }

    [MailChimpJsonProperty("fragment")]
    public string Fragment { get; set; }
}