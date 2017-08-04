// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InterestCategoryRequest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The interest category request.
    /// </summary>
    public class InterestCategoryRequest : QueryableBaseRequest
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [QueryString("type")]
        public string Type { get; set; }
    }
}