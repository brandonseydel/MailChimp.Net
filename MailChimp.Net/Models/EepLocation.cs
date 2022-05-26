// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EepLocation.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using System.Diagnostics;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The eep location.
    /// </summary>
    public class EepLocation : Base
    {
        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the region.
        /// </summary>
        public string Region { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Data.Add(Country, Region)
                ;
        }
    }
}