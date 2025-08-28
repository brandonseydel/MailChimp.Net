using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MailChimp.Net.Models;

public class ListTag
{
    /// <summary>
    /// Gets or sets the tag's name.
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the tag's id).
    /// </summary>
    [JsonProperty("id")]
    public string Id { get; set; }

}
