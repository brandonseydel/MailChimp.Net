using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class ListTag : Base, IId<string>
    {
        /// <summary>
        /// Gets or sets the tag's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the tag's id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Id.Add(Id)
                .Data.Add(Name)
                ;
        }
    }
}
