using System;
using System.Configuration;
using MailChimp.Net.Interfaces;

namespace MailChimp.Net
{
    public class MailChimpConfiguration : IMailChimpConfiguration
    {
        public static int DefaultLimit => Common.DefaultLimit;

        private string _apiKey;
        public string ApiKey
        {
            get { return _apiKey ?? (_apiKey = ConfigurationManager.AppSettings["MailChimpApiKey"]); }
            set { _apiKey = value; }
        }

        public int Limit { get; set; } = DefaultLimit;

        public string DataCenter
            => string.IsNullOrWhiteSpace(this.ApiKey)
                ? string.Empty
                : this.ApiKey.Substring(
                    this.ApiKey.LastIndexOf("-", StringComparison.Ordinal) + 1,
                    this.ApiKey.Length - this.ApiKey.LastIndexOf("-", StringComparison.Ordinal) - 1);

        public string AuthHeader => $"apikey {this.ApiKey}";
    }
}