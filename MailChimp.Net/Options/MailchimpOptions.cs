using System;

namespace MailChimp.Net
{
    public class MailchimpOptions
    {
        public int Limit { get; set; } = 1000;

        public string DataCenter {
            get {
                return string.IsNullOrWhiteSpace(ApiKey)
                ? string.Empty
                : ApiKey.Substring(
                    ApiKey.LastIndexOf("-", StringComparison.Ordinal) + 1,
                    ApiKey.Length - ApiKey.LastIndexOf("-", StringComparison.Ordinal) - 1);
            }
        }

        public string AuthHeader => $"apikey {ApiKey}";

        public string ApiKey { get; set; }
    }
}
