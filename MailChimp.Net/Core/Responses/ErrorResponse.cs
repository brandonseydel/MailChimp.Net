using Newtonsoft.Json;

namespace MailChimp.Net.Core.Responses
{
    public class ErrorResponse
    {
        /// <summary>
        /// The email address that could not be added or updated.
        /// </summary>
        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The error message indicating why the email address could not be added or updated.
        /// </summary>
        [JsonProperty("error")]
        public string Error { get; set; }
    }
}