using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Options;

namespace MailChimp.Net.Tests.Stubs
{
    public class StubMailchimpOptions : IOptions<MailchimpOptions>
    {
        private readonly MailchimpOptions _options;

        public StubMailchimpOptions(string key)
        {
            _options = new MailchimpOptions { ApiKey = key };
        }

        public StubMailchimpOptions(int limit)
        {
            _options = new MailchimpOptions { Limit = limit };
        }

        public StubMailchimpOptions(string datacenter, string token)
        {
            _options = new MailchimpOptions { DataCenter = datacenter,  OauthToken = token };
        }

        public MailchimpOptions Value => _options;
    }
}
