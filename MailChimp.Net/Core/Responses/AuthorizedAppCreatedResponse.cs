// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AuthorizedAppCreatedResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace MailChimp.Net.Core;

/// <summary>
/// The authorized app created response.
/// </summary>
public class AuthorizedAppCreatedResponse
{
    /// <summary>
    /// Gets or sets the access token.
    /// </summary>
    [JsonProperty("access_token")]
    public string AccessToken { get; set; }

    /// <summary>
    /// Gets or sets the viewer token.
    /// </summary>
    [JsonProperty("viewer_token")]
    public string ViewerToken { get; set; }
}