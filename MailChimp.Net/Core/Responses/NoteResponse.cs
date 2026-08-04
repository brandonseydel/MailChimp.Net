// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NoteResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

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
    [MailChimpJsonProperty("email_id")]
    public string EmailId { get; set; }

    /// <summary>
    /// Gets or sets the list id.
    /// </summary>
    [MailChimpJsonProperty("list_id")]
    public string ListId { get; set; }

    /// <summary>
    /// Gets or sets the notes.
    /// </summary>
    [MailChimpJsonProperty("notes")]
    public IEnumerable<Note> Notes { get; set; }
}