using MailChimp.Net.Interfaces;

namespace MailChimp.Net
{
    public class MailChimpOauthConfiguration : IMailChimpConfiguration
    {
        public static int DefaultLimit { get { return Common.DefaultLimit; } }

        public string OauthToken { get; set; }
        public int Limit { get; set; } = DefaultLimit;
        public string DataCenter { get; set; }

        public string AuthHeader => $"oauth {this.OauthToken}";
    }
}
