// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HttpRequestExtensions.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The http request extensions.
    /// </summary>
    public static class HttpRequestExtensions
    {
        /// <summary>
        /// The patch as json async.
        /// </summary>
        /// <param name="client">
        /// The client.
        /// </param>
        /// <param name="requestUri">
        /// The request uri.
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <param name="formatter">
        /// The formatter.
        /// </param>
        /// <typeparam name="T">
        /// </typeparam>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public static async Task<HttpResponseMessage> PatchAsJsonAsync<T>(
            this HttpClient client, 
            string requestUri, 
            T value)
        {
            string json = JsonConvert.SerializeObject(value, new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore
            });
            
            return await client.PatchAsync(requestUri, new StringContent(json)).ConfigureAwait(false);
        }

        /// <summary>
        /// The patch async.
        /// </summary>
        /// <param name="client">
        /// The client.
        /// </param>
        /// <param name="requestUri">
        /// The request uri.
        /// </param>
        /// <param name="content">
        /// The content.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public static async Task<HttpResponseMessage> PatchAsync(
            this HttpClient client, 
            string requestUri, 
            HttpContent content)
        {
            var request = new HttpRequestMessage
                              {
                                  Method = new HttpMethod("PATCH"), 
                                  RequestUri = new Uri(client.BaseAddress + requestUri), 
                                  Content = content
                              };
			client.DefaultRequestHeaders.ExpectContinue = false;
            return await client.SendAsync(request).ConfigureAwait(false);
        }

        /// <summary>
        /// The put as json async.
        /// </summary>
        /// <param name="client">
        /// The client.
        /// </param>
        /// <param name="requestUri">
        /// The request uri.
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <param name="formatter">
        /// The formatter.
        /// </param>
        /// <typeparam name="T">
        /// </typeparam>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public static async Task<HttpResponseMessage> PutAsJsonAsync<T>(
            this HttpClient client,
            string requestUri,
            T value)
        {
            string json = JsonConvert.SerializeObject(value, new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore
            });

            return await client.PutAsync(requestUri, new StringContent(json)).ConfigureAwait(false);
        }

        /// <summary>
        /// PostAsJsonAsync
        /// </summary>
        /// <param name="client">
        /// The client.
        /// </param>
        /// <param name="requestUri">
        /// The request uri.
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <param name="formatter">
        /// The formatter.
        /// </param>
        /// <typeparam name="T">
        /// </typeparam>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public static async Task<HttpResponseMessage> PostAsJsonAsync<T>(
            this HttpClient client,
            string requestUri,
            T value)
        {
            string json = JsonConvert.SerializeObject(value, new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore
            });

            return await client.PostAsync(requestUri, new StringContent(json)).ConfigureAwait(false);
        }

    }
}