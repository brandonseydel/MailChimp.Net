using Newtonsoft.Json;

namespace MailChimp.Net.Core.Responses
{
    public class MergeFields
    {
        [JsonProperty("FNAME")]
        public string FirstName { get; set; }

        [JsonProperty("LNAME")]
        public string LastName { get; set; }

        [JsonProperty("ADDRESS")]
        public string Address { get; set; }

        [JsonProperty("PHONE")]
        public string Phone { get; set; }
    }
}