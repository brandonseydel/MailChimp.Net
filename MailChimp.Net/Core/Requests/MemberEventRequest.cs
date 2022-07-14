namespace MailChimp.Net.Core.Requests
{
    /// <summary>A member event request.</summary>
    /// <seealso cref="QueryableBaseRequest"/>
    public class MemberEventRequest : QueryableBaseRequest
    {
        /// <summary>Gets or sets the number of. </summary>
        /// <value>The count.</value>
        [QueryString("count")]
        public int Count { get; set; }

        /// <summary>Gets or sets the fields.</summary>
        /// <value>The fields.</value>
        [QueryString("fields")]
        public string[] Fields { get; set; }

        /// <summary>Gets or sets the excluded fields.</summary>
        /// <value>The excluded fields.</value>
        [QueryString("exclude_fields")]
        public string[] ExcludedFields { get; set; }
    }
}
