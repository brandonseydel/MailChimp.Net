// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApiInfo.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The api info.
/// </summary>
public class ApiInfo
{
    /// <summary>
    /// Gets or sets the account id.
    /// </summary>
    [MailChimpJsonProperty("account_id")]
    public string AccountId { get; set; }

    [MailChimpJsonProperty("login_id")]
    public string LoginId { get; set; }
    /// <summary>
    /// Gets or sets the account name.
    /// </summary>
    [MailChimpJsonProperty("account_name")]
    public string AccountName { get; set; }
    [MailChimpJsonProperty("email")]
    public string Email { get; set; }
    [MailChimpJsonProperty("first_name")]
    public string FirstName { get; set; }
    [MailChimpJsonProperty("last_name")]
    public string LastName { get; set; }
    [MailChimpJsonProperty("username")]
    public string UserName { get; set; }
    [MailChimpJsonProperty("avatar_url")]
    public string AvatarUrl { get; set; }
    [MailChimpJsonProperty("role")]
    public string Role { get; set; }
    [MailChimpJsonProperty("member_since")]
    public string MemberSince { get; set; }
    [MailChimpJsonProperty("pricing_plan_type")]
    public string PricingPlanType { get; set; }
    [MailChimpJsonProperty("first_payment")]
    public string FirstPayment { get; set; }
    [MailChimpJsonProperty("account_timezone")]
    public string AccountTimezone { get; set; }
    [MailChimpJsonProperty("account_industry")]
    public string AccountIndustry { get; set; }
    [MailChimpJsonProperty("pro_enabled")]
    public bool ProEnabled { get; set; }

    [MailChimpJsonProperty("industry_stats")]
    public IndustryStats IndustryStats { get; set; }

    /// <summary>
    /// Gets or sets the contact.
    /// </summary>
    [MailChimpJsonProperty("contact")]
    public ApiContact Contact { get; set; }

    /// <summary>
    /// Gets or sets the last login.
    /// </summary>
    [MailChimpJsonProperty("last_login")]
    public string LastLogin { get; set; }



    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [MailChimpJsonProperty("_links")]
    public Link[] Links { get; set; }

    /// <summary>
    /// Gets or sets the total subscribers.
    /// </summary>
    [MailChimpJsonProperty("total_subscribers")]
    public int TotalSubscribers { get; set; }
}