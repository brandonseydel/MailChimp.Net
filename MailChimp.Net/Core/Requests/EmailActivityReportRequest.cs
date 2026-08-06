using System;

namespace MailChimp.Net.Core;

/// <summary>
/// The email activity report request.
/// </summary>
public class EmailActivityReportRequest : QueryableBaseRequest
{
    /// <summary>
    /// Restrict results to email activity events that occur after a specific time.
    /// Uses ISO 8601 time format: 2015-10-21T15:41:36+00:00.
    /// </summary>
    [QueryString("since")]
    public DateTime? Since { get; set; }
}
