using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class OperationResponse
    {
        [JsonProperty("status_code")]
        public int StatusCode { get; set; }
        [JsonProperty("operation_id")]
        public string OperationId { get; set; }
        [JsonProperty("response")]
        public string Response { get; set; }
    }
}
