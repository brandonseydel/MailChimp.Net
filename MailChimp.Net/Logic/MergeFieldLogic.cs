// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MergeFieldLogic.cs" company="Brandon Seydel">
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
    /// The merge field logic.
    /// </summary>
    public class MergeFieldLogic : BaseLogic
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MergeFieldLogic"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api key.
        /// </param>
        public MergeFieldLogic(string apiKey)
            : base(apiKey)
        {
        }
    }
}