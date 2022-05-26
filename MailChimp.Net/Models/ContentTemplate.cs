using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// </summary>
    public class ContentTemplate : Base, IId<int>
    {
        /// <summary>
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("sections")]
        public Dictionary<string, object> Sections { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Id.Add(Id)
                ;
        }
    }
}
