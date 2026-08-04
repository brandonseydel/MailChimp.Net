using System.Collections.Generic;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core;

public class Segment
{
    [MailChimpJsonProperty("name")]
    public string Name { get; set; }
    [MailChimpJsonProperty("static_segment")]
    public IEnumerable<string> EmailAddresses { get; set; }
    [MailChimpJsonProperty("options")]
    public SegmentOptions Options { get; set; }
}
