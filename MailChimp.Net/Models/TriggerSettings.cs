// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TriggerSettings.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;
using System.Diagnostics;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The trigger settings.
    /// </summary>
    public class TriggerSettings : Base
    {
        /// <summary>
        /// Gets or sets the runtime.
        /// </summary>
        [JsonProperty("runtime")]
        public Runtime Runtime { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether send immediately.
        /// </summary>
        [JsonProperty("send_immediately")]
        public bool SendImmediately { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether trigger on import.
        /// </summary>
        [JsonProperty("trigger_on_import")]
        public bool TriggerOnImport { get; set; }

        /// <summary>
        /// Gets or sets the workflow emails count.
        /// </summary>
        [JsonProperty("workflow_emails_count")]
        public int WorkflowEmailsCount { get; set; }

        /// <summary>
        /// Gets or sets the workflow type.
        /// </summary>
        [JsonProperty("workflow_type")]
        public string WorkflowType { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                ;
        }
    }
}