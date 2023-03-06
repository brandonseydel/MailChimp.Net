// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BatchResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// <summary>
//   The batch response.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using Newtonsoft.Json;

namespace MailChimp.Net.Core;

/// <summary>
/// The batch response.
/// </summary>
public class BatchResponse : BaseResponse
{
    [JsonProperty("batches")]
    public IEnumerable<Batch> Batches { get; set; }
}
