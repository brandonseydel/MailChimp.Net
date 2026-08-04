// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MessageResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

namespace MailChimp.Net.Core;

/// <summary>
/// The message response.
/// </summary>
public class MessageResponse : BaseResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MessageResponse"/> class.
    /// </summary>
    public MessageResponse()
    {
        Messages = new HashSet<Message>();
    }

    /// <summary>
    /// Gets or sets the messages.
    /// </summary>
    [MailChimpJsonProperty("conversation_messages")]
    public IEnumerable<Message> Messages { get; set; }
}