namespace MailChimp.Net.Core
{
    public abstract class QueryableBaseRequest : BaseRequest
    {
        [QueryString("count")]
        public int Limit { get; set; }
        [QueryString("offset")]
        public int Offset { get; set; }

   
    }
}