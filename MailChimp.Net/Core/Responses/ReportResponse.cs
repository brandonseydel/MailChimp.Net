// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

namespace MailChimp.Net.Core;

/// <summary>
/// The report response.
/// </summary>
public class ReportResponse : BaseResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ReportResponse"/> class.
    /// </summary>
    public ReportResponse()
    {
        Reports = new HashSet<Report>();
    }

    /// <summary>
    /// Gets or sets the reports.
    /// </summary>
    [MailChimpJsonProperty("reports")]
    public IEnumerable<Report> Reports { get; set; }
}