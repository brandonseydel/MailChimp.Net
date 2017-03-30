namespace MailChimp.Net.Interfaces
{
    public interface IMailChimpConfiguration
    {
        int Limit { get; set; }
        string DataCenter { get; }
        string AuthHeader { get; }
    }
}
