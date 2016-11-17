using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// One of the following actions: ‘open’, ‘click’, or ‘bounce’
    /// </summary>
    public enum EmailAction
    {
        [Description("")]
        None,
        Open,
        Click,
        Bounce
    }
}
