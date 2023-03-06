using Newtonsoft.Json;

namespace MailChimp.Net.Models;

public class Result
{
    [JsonProperty("campaign")]
    public Campaign Campaign { get; set; }

    [JsonProperty("snippet")]
    public string Snippet { get; set; }
}
