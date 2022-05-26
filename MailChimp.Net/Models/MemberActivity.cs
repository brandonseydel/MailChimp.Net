using MailChimp.Net.Core;

using Newtonsoft.Json;
using System.Diagnostics;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// An array of objects, each showing an interaction with the email.
    /// </summary>
    public class MemberActivity : Base
    {
        /// <summary>
        /// One of the following actions: ‘open’, ‘click’, or ‘bounce’
        /// </summary>
        
        [JsonConverter(typeof(StringEnumDescriptionConverter))]
        public EmailAction? Action { get; set; }
        public string Type { get; set; }
        public string Timestamp { get; set; }
        public string Url { get; set; }
        public string Ip { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Type.Add(Type)
                .Prefix.Add(Action)
                .Data.Add(Url)
                .Postfix.Add(Ip)
                ;
        }
    }
}
