using Newtonsoft.Json;
using System.Collections.Generic;

namespace MailChimp.Net.Models;

/// <summary>
/// </summary>
public class ContentTemplate
{
    /// <summary>
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// </summary>
    [JsonProperty("sections")]
    public Dictionary<string, object> Sections { get; set; }
}
