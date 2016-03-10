// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SegmentLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;

using MailChimp.Net.Core;
#pragma warning disable 1584,1711,1572,1581,1580

// ReSharper disable UnusedMember.Local
namespace MailChimp.Net.Logic
{
    /// <summary>
    /// The segment logic.
    /// </summary>
    public class SegmentLogic : BaseLogic
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentLogic"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api key.
        /// </param>
        public SegmentLogic(string apiKey)
            : base(apiKey)
        {
        }
    }
}