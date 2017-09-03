// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TemplateFolderResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The template folder response.
    /// </summary>
    public class TemplateFolderResponse : BaseResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateFolderResponse"/> class.
        /// </summary>
        public TemplateFolderResponse()
        {
            this.Folders = new HashSet<Folder>();
        }

        /// <summary>
        /// Gets or sets the folders.
        /// </summary>
        [JsonProperty("folders")]
        public IEnumerable<Folder> Folders { get; set; }
    }
}