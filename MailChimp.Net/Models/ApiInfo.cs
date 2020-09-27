// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApiInfo.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The api info.
    /// </summary>
    public class ApiInfo
    {
        /// <summary>
        /// Gets or sets the account id.
        /// </summary>
        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("login_id")]
        public string LoginId { get; set; }
        /// <summary>
        /// Gets or sets the account name.
        /// </summary>
        [JsonProperty("account_name")]
        public string AccountName { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        [JsonProperty("username")]
        public string UserName { get; set; }
        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }
        [JsonProperty("role")]
        public string Role { get; set; }
        [JsonProperty("member_since")]
        public string MemberSince { get; set; }
        [JsonProperty("pricing_plan_type")]
        public string PricingPlanType { get; set; }
        [JsonProperty("first_payment")]
        public string FirstPayment { get; set; }
        [JsonProperty("account_timezone")]
        public string AccountTimezone { get; set; }
        [JsonProperty("account_industry")]
        public string AccountIndustry { get; set; }
        [JsonProperty("pro_enabled")]
        public bool ProEnabled { get; set; }

        [JsonProperty("industry_stats")]
        public IndustryStats IndustryStats { get; set; }

        /// <summary>
        /// Gets or sets the contact.
        /// </summary>
        [JsonProperty("contact")]
        public ApiContact Contact { get; set; }

        /// <summary>
        /// Gets or sets the last login.
        /// </summary>
        [JsonProperty("last_login")]
        public string LastLogin { get; set; }



        /// <summary>
        /// Gets or sets the links.
        /// </summary>
        [JsonProperty("_links")]
        public Link[] Links { get; set; }

        /// <summary>
        /// Gets or sets the total subscribers.
        /// </summary>
        [JsonProperty("total_subscribers")]
        public int TotalSubscribers { get; set; }
    }
}