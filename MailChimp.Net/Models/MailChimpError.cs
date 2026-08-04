using System.Collections.Generic;
using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

public class MailChimpApiError
{
    [MailChimpJsonProperty("type")]
    public string Type { get; set; }
    [MailChimpJsonProperty("title")]
    public string Title { get; set; }
    [MailChimpJsonProperty("status")]
    public int Status { get; set; }
    [MailChimpJsonProperty("detail")]
    public string Detail { get; set; }
    [MailChimpJsonProperty("instance")]
    public string Instance { get; set; }
    [MailChimpJsonProperty("errors")]
    public List<MailChimpError> Errors { get; set; } = new List<MailChimpError>();
}

public class MailChimpError
{
    [MailChimpJsonProperty("field")]
    public string Field { get; set; }
    [MailChimpJsonProperty("message")]
    public string Message { get; set; }
}
