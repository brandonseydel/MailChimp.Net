using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Net.Core
{
    public class InterestCategoryRequest : QueryableBaseRequest
    {
        [QueryString("type")]
        public int Type { get; set; }
    }
}
