using System;

namespace MailChimp.Net.Core
{
    public class MailChimpNotFoundException : Exception
    {
        public MailChimpNotFoundException(string message) : base(message)
        {
        }
    }
}
