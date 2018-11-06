using System.Collections.Generic;

namespace MailChimp.Net.Models
{
    public enum MarketingPermissionText
    {
        Email,
        DirectMail,
        CustomizedOnlineAdvertising
    }


    public static class MarketingPermissionTextHelpers
    {
        public static Dictionary<string, MarketingPermissionText> GetMarketingPermissions() =>
            new Dictionary<string, MarketingPermissionText>
            {
                { nameof(MarketingPermissionText.Email), MarketingPermissionText.Email },
                { "Direct Mail", MarketingPermissionText.DirectMail },
                { "Customized Online Advertising", MarketingPermissionText.CustomizedOnlineAdvertising }
            };
    }
}
