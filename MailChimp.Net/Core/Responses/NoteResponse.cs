// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NoteResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

using Newtonsoft.Json;

namespace MailChimp.Net.Core;

/// <summary>
/// The note response.
/// </summary>
public class NoteResponse : BaseResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NoteResponse"/> class.
    /// </summary>
    public NoteResponse()
    {
        Notes = new HashSet<Note>();
    }

    /// <summary>
    /// Gets or sets the email id.
    /// </summary>
    [JsonProperty("email_id")]
    public string EmailId { get; set; }

    /// <summary>
    /// Gets or sets the list id.
    /// </summary>
    [JsonProperty("list_id")]
    public string ListId { get; set; }

    /// <summary>
    /// Gets or sets the notes.
    /// </summary>
    [JsonProperty("notes")]
    public IEnumerable<Note> Notes { get; set; }
}