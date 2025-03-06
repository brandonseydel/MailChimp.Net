using Microsoft.Extensions.Options;

namespace MailChimp.Net.Tests
{
    public class StubMailchimpOptions : IOptions<MailChimpOptions>
    {
        private readonly MailChimpOptions _options;

        public StubMailchimpOptions(string key)
        {
            _options = new MailChimpOptions { ApiKey = key };
        }

        public StubMailchimpOptions(int limit)
        {
            _options = new MailChimpOptions { Limit = limit };
        }

        public StubMailchimpOptions(string datacenter, string token)
        {
            _options = new MailChimpOptions { DataCenter = datacenter,  OauthToken = token };
        }

        public MailChimpOptions Value => _options;
    }
}
