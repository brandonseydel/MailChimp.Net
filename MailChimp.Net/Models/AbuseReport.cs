// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AbuseReport.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace MailChimp.Net.Models;

/// <summary>
/// The abuse report.
/// </summary>
public class AbuseReport
{
    /// <summary>
    /// Gets or sets the campaign id.
    /// </summary>
    [JsonProperty("campaign_id")]
    public string CampaignId { get; set; }

    /// <summary>
    /// Gets or sets the date.
    /// </summary>
    [JsonProperty("date")]
    public string Date { get; set; }

    /// <summary>
    /// Gets or sets the email address.
    /// </summary>
    [JsonProperty("email_address")]
    public string EmailAddress { get; set; }

    /// <summary>
    /// Gets or sets the email id.
    /// </summary>
    [JsonProperty("email_id")]
    public string EmailId { get; set; }

    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the list id.
    /// </summary>
    [JsonProperty("list_id")]
    public string ListId { get; set; }
}