namespace MailChimp.Net
{
    public class MailChimpConfiguration
    {
        public static int DefaultLimit = 1000;
        public string ApiKey { get; set; }
        public int Limit { get; set; }
    }
}