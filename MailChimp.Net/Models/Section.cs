using System.Diagnostics;

namespace MailChimp.Net.Models
{
    public class Section : Base
    {
        public string Ribbon { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Data.Add(Ribbon)
                ;
        }
    }
}
