// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContentRequest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

using Newtonsoft.Json;

namespace MailChimp.Net.Core;

/// <summary>
/// The content request.
/// </summary>
public class ContentRequest
{
    /// <summary>
    /// Available when uploading an archive to create campaign content. The archive should include all campaign content and images.
    /// <a href="http://kb.mailchimp.com/campaigns/ways-to-build/import-a-zip-file-to-create-a-campaign?utm_source=mc-api&amp;utm_medium=docs&amp;utm_campaign=apidocs&amp;_ga=1.69087766.629889474.1468257895">Learn More.</a>
    /// </summary>
    [JsonProperty("archive")]
    public Archive Archive { get; set; }

    /// <summary>
    /// The raw HTML for the campaign.
    /// </summary>
    [JsonProperty("html")]
    public string Html { get; set; }

    /// <summary>
    /// Gets or sets the plain text.
    /// </summary>
    [JsonProperty("plain_text")]
    public string PlainText { get; set; }

    /// <summary>
    /// When importing a campaign, the URL where the HTML lives.
    /// </summary>
    [JsonProperty("url")]
    public string Url { get; set; }

    /// <summary>
    /// Content options for Multivariate Campaigns. Each content option must provide HTML content and may optionally provide plain text.
    /// For campaigns not testing content, only one object should be provided.
    /// </summary>
    [JsonProperty("variate_contents")]
    public IEnumerable<VariateContents> VariateContents { get; set; }

    /// <summary>
    ///	Use this template to generate the HTML content of the campaign
    /// </summary>
    [JsonProperty("template")]
    public ContentTemplate Template { get; set; }
}
