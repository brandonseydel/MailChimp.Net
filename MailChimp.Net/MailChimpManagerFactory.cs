using MailChimp.Net.Interfaces;

namespace MailChimp.Net
{
    public class MailChimpManagerFactory : IMailChimpManagerFactory
    {
        public IMailChimpManager Create(string apiKey)
        {
            return new MailChimpManager(apiKey);
        }

        public IMailChimpManager Create(MailChimpOptions options)
        {
            return new MailChimpManager(options);
        }
    }
}