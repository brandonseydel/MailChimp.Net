// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Client.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;
using System.Diagnostics;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The client.
    /// </summary>
    public class Client : Base
    {
        /// <summary>
        /// Gets or sets the client name.
        /// </summary>
        [JsonProperty("client")]
        public string ClientName { get; set; }

        /// <summary>
        /// Gets or sets the list id.
        /// </summary>
        [JsonProperty("list_id")]
        public string ListId { get; set; }

        /// <summary>
        /// Gets or sets the members.
        /// </summary>
        [JsonProperty("members")]
        public int Members { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Data.Add(ClientName)
                ;
        }

    }
}