using System.Configuration;

namespace MailChimp.Net.Core
{
    public abstract class MailManagerBase
    {
        protected MailManagerBase(string apiKey)
        {
            _apiKey = apiKey;
        }

        protected MailManagerBase() { }

        private static string _apiKey;

        protected static string ApiKey
        {
            get { return _apiKey ?? ConfigurationManager.AppSettings["MailChimpApiKey"]; }
            set { _apiKey = value; }
        }
    }
}