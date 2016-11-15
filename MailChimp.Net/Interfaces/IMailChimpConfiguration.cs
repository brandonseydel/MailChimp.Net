using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Net.Interfaces
{
    public interface IMailChimpConfiguration
    {
        int Limit { get; set; }
        string DataCenter { get; }
        string AuthHeader { get; }
    }
}
