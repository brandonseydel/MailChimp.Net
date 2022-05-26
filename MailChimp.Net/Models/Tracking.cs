// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Tracking.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;
using System.Diagnostics;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The tracking.
    /// </summary>
    public class Tracking : Base
    {
        /// <summary>
        /// Gets or sets the clicktale.
        /// </summary>
        [JsonProperty("clicktale")]
        public string Clicktale { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether ecomm 360.
        /// </summary>
        [JsonProperty("ecomm360")]
        public bool Ecomm360 { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether goal tracking.
        /// </summary>
        [JsonProperty("goal_tracking")]
        public bool GoalTracking { get; set; }

        /// <summary>
        /// Gets or sets the google analytics.
        /// </summary>
        [JsonProperty("google_analytics")]
        public string GoogleAnalytics { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether html clicks.
        /// </summary>
        [JsonProperty("html_clicks")]
        public bool HtmlClicks { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether opens.
        /// </summary>
        [JsonProperty("opens")]
        public bool Opens { get; set; }

        [JsonProperty("salesforce")]
        public SalesForce SalesForce { get; set; }

        [JsonProperty("highrise")]
        public HighRise HighRise { get; set; }

        [JsonProperty("capsule")]
        public Capsule Capsule { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether text clicks.
        /// </summary>
        [JsonProperty("text_clicks")]
        public bool TextClicks { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                ;
        }
    }
}