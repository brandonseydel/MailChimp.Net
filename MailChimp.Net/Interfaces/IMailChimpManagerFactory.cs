namespace MailChimp.Net.Interfaces
{
    public interface IMailChimpManagerFactory
    {
        IMailChimpManager Create(string apiKey);
        IMailChimpManager Create(MailChimpOptions options);
    }
}