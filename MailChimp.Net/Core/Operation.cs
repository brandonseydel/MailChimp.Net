using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class Operation
    {
        /// <summary>
        /// The HTTP method to use for the operation.
        /// Possible Values:
        /// GET - POST - PUT - PATCH
        /// </summary>
        public string Method { get; set; }
        /// <summary>
        /// The relative path to use for the operation.
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// Any URL params to use, only applies to GET operations.
        /// </summary>
        public string Params { get; set; }
        /// <summary>
        /// A string containing the JSON body to use with the request.
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// An optional client-supplied id returned with the operation results.
        /// </summary>
        [JsonProperty("operation_id")]
        public string OperationId { get; set; }
    }
}
