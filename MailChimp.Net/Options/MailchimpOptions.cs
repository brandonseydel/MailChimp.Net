using System;

namespace MailChimp.Net
{
    public class MailchimpOptions
    {
        public int Limit { get; set; } = 1000;

        private string _dataCenter;

        public string DataCenter {
            get {
                if (_dataCenter == null)
                {
                    _dataCenter = string.IsNullOrWhiteSpace(ApiKey)
                    ? string.Empty
                    : ApiKey.Substring(
                        ApiKey.LastIndexOf("-", StringComparison.Ordinal) + 1,
                        ApiKey.Length - ApiKey.LastIndexOf("-", StringComparison.Ordinal) - 1);
                }
                return _dataCenter;
            }
            set { _dataCenter = value; }
        }

        public string AuthHeader => $"apikey {ApiKey}";

        public string ApiKey { get; set; }

        public string OauthToken { get; set; }
    }
}
