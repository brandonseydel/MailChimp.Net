using System;
using System.Linq;
using MailChimp.Net.Interfaces;
using Microsoft.Extensions.Configuration;

namespace MailChimp.Net
{
    public class MailChimpConfiguration : IMailChimpConfiguration
    {
        public static int DefaultLimit => Common.DefaultLimit;

        public MailChimpConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile("logging.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();
            
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        private string _apiKey;
        public string ApiKey
        {
            get { return _apiKey ?? (_apiKey = Configuration
                    .GetSection("AppSettings")
                    .GetChildren()
                    .AsEnumerable()
                    .FirstOrDefault(x => x.Key == "MailChimpApiKey").Value); }
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