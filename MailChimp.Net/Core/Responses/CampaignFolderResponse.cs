// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CampaignFolder.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// <summary>
//   The campaign folder response.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

namespace MailChimp.Net.Core;


/// <summary>
/// The campaign folder response.
/// </summary>
public class CampaignFolderResponse : BaseResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CampaignFolderResponse"/> class.
    /// </summary>
    public CampaignFolderResponse()
    {
        Folders = new HashSet<Folder>();
    }

    /// <summary>
    /// Gets or Sets an array of objects representing campaign folders.
    /// </summary>
    [MailChimpJsonProperty("folders")]
    public IEnumerable<Folder> Folders { get; set; }

}

