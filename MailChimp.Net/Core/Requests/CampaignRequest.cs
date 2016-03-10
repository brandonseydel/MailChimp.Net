// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CampaignRequest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace MailChimp.Net.Core
{
    /// <summary>
    /// The campaign request.
    /// </summary>
    public class CampaignRequest : QueryableBaseRequest
    {
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        [QueryString("status")]
        public CampaignStatus? Status { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [QueryString("type")]
        public CampaignType? Type { get; set; }
    }
}