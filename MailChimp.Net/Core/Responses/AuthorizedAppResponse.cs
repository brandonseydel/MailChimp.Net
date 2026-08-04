// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AuthorizedAppResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

namespace MailChimp.Net.Core;

/// <summary>
/// The authorized app response.
/// </summary>
public class AuthorizedAppResponse : BaseResponse
{
    /// <summary>
    /// Gets or sets the apps.
    /// </summary>
    [MailChimpJsonProperty("apps")]
    public IEnumerable<App> Apps { get; set; }
}