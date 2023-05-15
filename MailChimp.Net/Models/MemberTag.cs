// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Member.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using MailChimp.Net.Core;

using Newtonsoft.Json;

namespace MailChimp.Net.Models;

/// <summary>
/// The tag for a member
/// </summary>
public class MemberTag
{
    /// <summary>
    /// Gets or sets the identifier.
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the tag's name.
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// The date and time the tag was added to the list member in ISO 8601 format.
    /// </summary>
    [JsonProperty("date_added")]
    public DateTime? DateAdded { get; set; }

    /// <summary>
    /// The status for the tag on the member, pass in active to add a tag or inactive to remove it. Possible values: "inactive" or "active".
    /// </summary>
    [JsonProperty("status")]
    public string Status { get; set; }
}
