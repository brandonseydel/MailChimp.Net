// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ListResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using MailChimp.Net.Models;

using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The list response.
    /// </summary>
    public class ListResponse : BaseResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListResponse"/> class.
        /// </summary>
        public ListResponse()
        {
            Lists = new HashSet<List>();
        }

        /// <summary>
        /// Gets or sets the lists.
        /// </summary>
        [JsonProperty("lists")]
        public IEnumerable<List> Lists { get; set; }
    }
}