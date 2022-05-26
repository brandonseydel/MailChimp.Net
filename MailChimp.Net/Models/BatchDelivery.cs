using Newtonsoft.Json;
using System.Diagnostics;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// Choose whether the campaign should use Batch Delivery. Cannot be set to <see langword="true"/> for campaigns using Timewarp.
    /// </summary>
    public class BatchDelivery : Base
    {
        /// <summary>
        /// The delay, in minutes, between batches.
        /// </summary>
        [JsonProperty("batch_delay")]
        public int Delay { get; set; }

        /// <summary>
        /// The number of batches for the campaign send.
        /// </summary>
        [JsonProperty("batch_count")]
        public int Count { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Data.AddExpression(Delay)
                .Data.AddExpression(Count)
                ;
        }
    }
}
