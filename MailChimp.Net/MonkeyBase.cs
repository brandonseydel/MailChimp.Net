using System.Configuration;

namespace MailChimp.Net
{
    public abstract class MonkeyBase
    {
        protected MonkeyBase(string apiKey)
        {
            _apiKey = apiKey;
        }

        protected MonkeyBase() { }

        private static string _apiKey;

        protected static string ApiKey
        {
            get { return _apiKey ?? ConfigurationManager.AppSettings["MailChimpApiKey"] ?? _apiKey; }
            set { _apiKey = value; }
        }
    }
}