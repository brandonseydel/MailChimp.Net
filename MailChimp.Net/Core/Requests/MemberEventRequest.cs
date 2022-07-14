namespace MailChimp.Net.Core.Requests
{
    public class MemberEventRequest : QueryableBaseRequest
    {
        [QueryString("count")]
        public int Count { get; set; }

        [QueryString("fields")]
        public string[] Fields { get; set; }

        [QueryString("exclude_fields")]
        public string[] ExcludedFields { get; set; }
    }
}
