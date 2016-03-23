// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MemberRequest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace MailChimp.Net.Core
{
    /// <summary>
    /// The member request.
    /// </summary>
    public class MemberRequest : QueryableBaseRequest
    {
        [QueryString("email_type")]
        public string EmailType { get; set; }

        [QueryString("status")]
        public bool Status { get; set; }

        [QueryString("since_timestamp_opt")]
        public string SinceTimestamp { get; set; }

        [QueryString("before_timestamp_opt")]
        public string BeforeTimestamp { get; set; }

        [QueryString("since_last_changed")]
        public string SinceLastChanged { get; set; }

        [QueryString("before_last_changed")]
        public string BeforeLastChanged { get; set; }
    }
}