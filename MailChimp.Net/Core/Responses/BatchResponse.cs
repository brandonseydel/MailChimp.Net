// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BatchResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// <summary>
//   The batch response.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
namespace MailChimp.Net.Core;

/// <summary>
/// The batch response.
/// </summary>
public class BatchResponse : BaseResponse
{
    [MailChimpJsonProperty("batches")]
    public IEnumerable<Batch> Batches { get; set; }
}
