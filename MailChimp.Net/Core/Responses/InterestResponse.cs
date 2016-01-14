using MailChimp.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Net.Core.Responses
{
    public class InterestResponse : BaseResponse
    {
        public IEnumerable<Interest> Interests { get; set; }
    }
}
