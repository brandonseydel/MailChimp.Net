using System.Configuration;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public abstract class MailManagerBase
    {
        protected MailManagerBase(string apiKey) : this()
        {
            _apiKey = apiKey;
        }

        protected MailManagerBase()
        {
            JsonConvert.DefaultSettings = ()
             => new JsonSerializerSettings {NullValueHandling = NullValueHandling.Ignore};
        }

        private static string _apiKey;

        protected static string ApiKey
        {
            get { return _apiKey ?? ConfigurationManager.AppSettings["MailChimpApiKey"]; }
            set { _apiKey = value; }
        }
    }
}