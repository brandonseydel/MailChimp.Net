// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AutomationEmailResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

using Newtonsoft.Json;

namespace MailChimp.Net.Core;

/// <summary>
/// The automation email response.
/// </summary>
public class AutomationEmailResponse : BaseResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AutomationEmailResponse"/> class.
    /// </summary>
    public AutomationEmailResponse()
    {
        Emails = new HashSet<Email>();
    }

    /// <summary>
    /// Gets or sets the emails.
    /// </summary>
    [JsonProperty("emails")]
    public IEnumerable<Email> Emails { get; set; }

    /// <summary>
    /// Gets or sets the workflow id.
    /// </summary>
    [JsonProperty("workflow_id")]
    public string WorkflowId { get; set; }
}