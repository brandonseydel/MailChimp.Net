using System;

namespace MailChimp.Net
{
    public class MailChimpOptions
    {
        public int Limit { get; set; } = 1000;

        private string _dataCenter;

        public string DataCenter
        {
            get => this._dataCenter ?? (this._dataCenter = string.IsNullOrWhiteSpace(this.ApiKey)
                                                               ? string.Empty
                                                               : this.ApiKey.Substring(
                                                                                       this.ApiKey.LastIndexOf("-", StringComparison.Ordinal) + 1,
                                                                                       this.ApiKey.Length - this.ApiKey.LastIndexOf("-", StringComparison.Ordinal) - 1));
            set => _dataCenter = value;
        }

        public string AuthHeader => $"apikey {ApiKey}";

        public string ApiKey { get; set; }

        public string OauthToken { get; set; }
    }
}
