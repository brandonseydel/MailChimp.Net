// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SentTo.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The sent to merge fields
    /// </summary>
    public class SentToMergeFields
    {
        /// <summary>
        /// Gets or sets the merge fields.
        /// </summary>
        public string FieldName { get; set; }
        public string FieldValue { get; set; }
    }
}