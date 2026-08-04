using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

public class SegmentCondition
{
    [MailChimpJsonProperty("type")]
    public string Type { get; set; }
    [MailChimpJsonProperty("operator")]
    public string Operator { get; set; }
    [MailChimpJsonProperty("extra")]
    public string Extra { get; set; }
    [MailChimpJsonProperty("field")]
    public string Field { get; set; }
    [MailChimpJsonProperty("value")]
    public string Value { get; set; }
}
