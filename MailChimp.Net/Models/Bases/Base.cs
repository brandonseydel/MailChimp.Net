using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MailChimp.Net.Models {
    [DebuggerDisplay(Debugger2.GetDebuggerDisplay)]
    public class Base : IGetDebuggerDisplayBuilder {
        public override string ToString() {
            return GetDebuggerDisplay();
        }

        string IGetDebuggerDisplay.GetDebuggerDisplay() {
            return GetDebuggerDisplay();
        }

        DisplayBuilder IGetDebuggerDisplayBuilder.GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return GetDebuggerDisplayBuilder(Builder);
        }


        internal string GetDebuggerDisplay() {
            return IGetDebuggerDisplayDefaults.GetDebuggerDisplay(this);
        }

        internal virtual DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return IGetDebuggerDisplayDefaults.GetDebuggerDisplayBuilder(this, Builder);
        }
    }

}
