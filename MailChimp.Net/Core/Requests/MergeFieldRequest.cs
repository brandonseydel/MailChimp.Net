using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Net.Core
{
    public class MergeFieldRequest : QueryableBaseRequest
    {
        [QueryString("type")]
        public string Type { get; set; }
        [QueryString("required")]
        public string Required { get; set; }
    }
}
