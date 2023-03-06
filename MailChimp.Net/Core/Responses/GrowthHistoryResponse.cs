// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GrowthHistoryResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

using Newtonsoft.Json;

namespace MailChimp.Net.Core;

/// <summary>
/// The growth history response.
/// </summary>
public class GrowthHistoryResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GrowthHistoryResponse"/> class.
    /// </summary>
    public GrowthHistoryResponse()
    {
        History = new HashSet<History>();
        Links = new HashSet<Link>();
    }

    /// <summary>
    /// Gets or sets the history.
    /// </summary>
    [JsonProperty("history")]
    public IEnumerable<History> History { get; set; }

    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [JsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }

    /// <summary>
    /// Gets or sets the list id.
    /// </summary>
    [JsonProperty("list_id")]
    public string ListId { get; set; }

    /// <summary>
    /// Gets or sets the total items.
    /// </summary>
    [JsonProperty("total_items")]
    public int TotalItems { get; set; }
}