// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryableBaseRequest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace MailChimp.Net.Core
{
    /// <summary>
    /// The queryable base request.
    /// </summary>
    public abstract class QueryableBaseRequest : BaseRequest
    {
        /// <summary>
        /// Gets or sets the limit.
        /// </summary>
        [QueryString("count")]
        public int Limit { get; set; }

        /// <summary>
        /// Gets or sets the offset.
        /// </summary>
        [QueryString("offset")]
        public int Offset { get; set; }
    }
}