using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Net.Core
{
    public static class HttpRequestExtensions
    {
        public static async Task<HttpResponseMessage> PutAsJsonAsync<T>(this HttpClient client, string requestUri, T value, JsonMediaTypeFormatter formatter = null)
        {
            var jsonFormatter = formatter ?? new JsonMediaTypeFormatter
            {
                SerializerSettings = {NullValueHandling = NullValueHandling.Ignore}
            };
            var content = new ObjectContent<T>(value, jsonFormatter);
            return await client.PutAsync(requestUri, content);
        }
    }
}
