// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChimpChatterResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

namespace MailChimp.Net.Core;

/// <summary>
/// The chimp chatter response.
/// </summary>
public class ChimpChatterResponse : BaseResponse
{
    /// <summary>
    /// Gets or sets the chimp chatter acitivities.
    /// </summary>
    [MailChimpJsonProperty("chimp_chatter")]
    public IEnumerable<ChimpChatter> ChimpChatters { get; set; } = new HashSet<ChimpChatter>();


}