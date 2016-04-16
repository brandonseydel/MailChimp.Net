using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Net.Models
{
    public class SegmentCondition
    {
        public string Type { get; set; }
        public string Operator { get; set; }
        public string Extra { get; set; }
        public string Field { get; set; }
        public string Value { get; set; }
    }
}
