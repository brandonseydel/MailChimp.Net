namespace MailChimp.Net.Core;

public class CampaignSearchRequest : BaseRequest
{
    /// <summary>
    /// The search query used to filter results.
    /// </summary>
    public string Query { get; set; }
    /// <summary>
    /// To have the match highlighted with something (like a strong HTML tag),
    /// both this and snip_end must be passed.
    /// This parameter has a 25-character limit.
    /// </summary>
    public string SnipStart { get; set; }
    /// <summary>
    /// To have the match highlighted with something (like a strong HTML tag), both this and snip_start must be passed. This parameter has a 25-character limit.
    /// </summary>
    public string SnipEnd { get; set; }
    /// <summary>
    /// The number of instances to skip from the beginning of the collection. Default value is 0.
    /// </summary>
    public int Offset { get; set; }
}
