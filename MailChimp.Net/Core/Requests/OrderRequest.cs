namespace MailChimp.Net.Core
{
    public class OrderRequest : QueryableBaseRequest
    {
        [QueryString("customer_id")]
        public string CustomerId { get; set; }
    }
}
