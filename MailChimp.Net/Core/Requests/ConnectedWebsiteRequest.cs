using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MailChimp.Net.Core.Requests
{
    public class ConnectedWebsiteRequest
    {
        [MailChimpJsonProperty("domain")]
        public string domain { get; set; }

        [MailChimpJsonProperty("foreign_id")]
        public string foreign_id { get; set; }
    }
}