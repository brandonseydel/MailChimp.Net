using System;

namespace MailChimp.Net.Core
{
    [Serializable]
    public class MailChimpNotFoundException : Exception
    {
        public MailChimpNotFoundException(string message) : base(message)
        {
        }
    }
}
