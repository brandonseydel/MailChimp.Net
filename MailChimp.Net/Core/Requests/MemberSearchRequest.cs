namespace MailChimp.Net.Core
{
    public class MemberSearchRequest : BaseRequest
    {
        /// <summary>
        /// The search query used to filter results.
        /// </summary>
        public string Query { get; set; }
        /// <summary>
        /// The unique id for the list.
        /// </summary>
        [QueryString("list_id")]
        public string ListId { get; set; }
        /// <summary>
        /// The number of instances to skip from the beginning of the collection. Default value is 0.
        /// </summary>
        public int Offset { get; set; }

    }
}
