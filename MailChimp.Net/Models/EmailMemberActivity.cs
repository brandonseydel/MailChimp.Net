using Newtonsoft.Json;

namespace MailChimp.Net.Models;

public class EmailMemberActivity
{
    [JsonProperty("action")]
    public string Action { get; set; }

    [JsonProperty("timestamp")]
    public string Timestamp { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("ip")]
    public string Ip { get; set; }
}
