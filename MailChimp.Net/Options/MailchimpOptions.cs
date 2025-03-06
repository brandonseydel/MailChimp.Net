using System;

namespace MailChimp.Net
{
    public class MailChimpOptions
    {
        public int Limit { get; set; } = 1000;

        private string _dataCenter;
        private string _authHeader;
        private string _apiKey;
        private string _oauthToken;

        public string DataCenter
        {
            get => this._dataCenter ?? (this._dataCenter = string.IsNullOrWhiteSpace(this.ApiKey)
                ? string.Empty
                : this.ApiKey.Substring(
                    this.ApiKey.LastIndexOf("-", StringComparison.Ordinal) + 1,
                    this.ApiKey.Length - this.ApiKey.LastIndexOf("-", StringComparison.Ordinal) - 1));
            set => _dataCenter = value;
        }

        public string AuthHeader => _authHeader;

        public string ApiKey
        {
            get { return _apiKey; }
            set
            {
                _apiKey = value;
                _oauthToken = null;
                _authHeader = $"apikey {_apiKey}";
            }
        }

        public string OauthToken
        {
            get { return _oauthToken; }
            set
            {
                _oauthToken = value;
                _apiKey = null;
                _authHeader = $"OAuth {_oauthToken}";
            }
        }
    }
}
