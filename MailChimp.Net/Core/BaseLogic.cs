using System;
using System.Net.Http;
using System.Security.Cryptography;

namespace MailChimp.Net.Core
{
    public class BaseLogic
    {
        public BaseLogic(string apiKey)
        {
            _apiKey = apiKey;
        }

        private readonly string _apiKey;

        private string _dataCenter => _apiKey.Substring(_apiKey.LastIndexOf("-") + 1, _apiKey.Length - _apiKey.LastIndexOf("-") - 1);

        public HttpClient CreateMailClient(string resource)
        {
            var client = new HttpClient {BaseAddress = new Uri($"https://{_dataCenter}.api.mailchimp.com/3.0/{resource}")};
            client.DefaultRequestHeaders.Add("Authorization", $"apikey {_apiKey}");
            return client;
        }

        internal string Hash(string emailAddress)
        {
            using (var md5 = MD5.Create())
            {
                return md5.GetMd5Hash(emailAddress);
            }
        }



    }
}