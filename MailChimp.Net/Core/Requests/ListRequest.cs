// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ListRequest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace MailChimp.Net.Core
{
    /// <summary>
    /// The list request.
    /// </summary>
    public class ListRequest : QueryableBaseRequest
    {
        
        [QueryString("before_date_created")]
        public string BeforeDateCreated { get; set; }

        [QueryString("since_date_created")]
        public string SinceDateCreated { get; set; }

        [QueryString("before_campaign_last_sent")]
        public string  BeforeCampaignLastSent { get; set; }

        [QueryString("since_campaign_last_sent")]
        public string SinceCampaignLastSent { get; set; }

        [QueryString("email")]
        public string Email { get; set; }

    }
}