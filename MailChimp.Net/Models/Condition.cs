// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Condition.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;
using Newtonsoft.Json;
using System.Diagnostics;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The condition.
    /// </summary>
    public class Condition : Base
    {
        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("condition_type")]
        [JsonConverter(typeof(StringEnumDescriptionConverter))]
        public ConditionType Type { get; set; }

        [JsonProperty("op")]
        [JsonConverter(typeof(StringEnumDescriptionConverter))]
        public Operator Operator { get; set; }

        [JsonProperty("extra")]
        public string Extra { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        [JsonProperty("value")]
        public dynamic Value { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Type.Add(Type)
                .Data.Add(Field, Operator, Value)
                .Postfix.Add(Extra)
                ;
        }

    }
}