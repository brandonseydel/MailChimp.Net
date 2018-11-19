using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

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
        public static Dictionary<string, MarketingPermissionText> GetMarketingPermissions()
        {
            var dictionary = new Dictionary<string, MarketingPermissionText>();

            var regex = new Regex(@"
                (?<=[A-Z])(?=[A-Z][a-z]) |
                 (?<=[^A-Z])(?=[A-Z]) |
                 (?<=[A-Za-z])(?=[^A-Za-z])", RegexOptions.IgnorePatternWhitespace);

            foreach (MarketingPermissionText marketingPermissionText in Enum.GetValues(typeof(MarketingPermissionText)))
            {
                dictionary.Add(regex.Replace(marketingPermissionText.ToString(), " "), marketingPermissionText);
            }

            return dictionary;
        }
    }
}