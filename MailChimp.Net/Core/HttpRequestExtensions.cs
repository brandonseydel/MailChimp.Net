// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HttpRequestExtensions.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
#if !NET10_0_OR_GREATER
using Newtonsoft.Json;
#endif

namespace MailChimp.Net.Core;

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
    /// <typeparam name="T">
    /// </typeparam>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
#if NET10_0_OR_GREATER
    public static async Task<HttpResponseMessage> PatchAsJsonAsync<T>(
        this HttpClient client,
        string requestUri,
        T value)
    {
        var content = new StringContent(
            MailChimpSerializer.Serialize(value),
            Encoding.UTF8,
            "application/json");

        return await client.PatchAsync(requestUri, content).ConfigureAwait(false);
    }
#else
    public static async Task<HttpResponseMessage> PatchAsJsonAsync<T>(
        this HttpClient client, 
        string requestUri, 
        T value,
        JsonSerializerSettings settings = null)
    {
        var content = new StringContent(
            MailChimpSerializer.Serialize(value, settings),
            Encoding.UTF8,
            "application/json");

        return await client.PatchAsync(requestUri, content).ConfigureAwait(false);
    }
#endif

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
    /// <typeparam name="T">
    /// </typeparam>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
#if NET10_0_OR_GREATER
    public static async Task<HttpResponseMessage> PutAsJsonAsync<T>(
        this HttpClient client,
        string requestUri,
        T value)
    {
        var content = new StringContent(
            MailChimpSerializer.Serialize(value),
            Encoding.UTF8,
            "application/json");

        return await client.PutAsync(requestUri, content).ConfigureAwait(false);
    }
#else
    public static async Task<HttpResponseMessage> PutAsJsonAsync<T>(
        this HttpClient client,
        string requestUri,
        T value,
        JsonSerializerSettings settings = null)
    {
        var content = new StringContent(
            MailChimpSerializer.Serialize(value, settings),
            Encoding.UTF8,
            "application/json");

        return await client.PutAsync(requestUri, content).ConfigureAwait(false);
    }
#endif

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
    /// <typeparam name="T">
    /// </typeparam>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
#if NET10_0_OR_GREATER
    public static async Task<HttpResponseMessage> PostAsJsonAsync<T>(
        this HttpClient client,
        string requestUri,
        T value)
    {
        var content = new StringContent(
            MailChimpSerializer.Serialize(value),
            Encoding.UTF8,
            "application/json");

        return await client.PostAsync(requestUri, content).ConfigureAwait(false);
    }
#else
    public static async Task<HttpResponseMessage> PostAsJsonAsync<T>(
        this HttpClient client,
        string requestUri,
        T value,
        JsonSerializerSettings settings = null)
    {
        var content = new StringContent(
            MailChimpSerializer.Serialize(value, settings),
            Encoding.UTF8,
            "application/json");

        return await client.PostAsync(requestUri, content).ConfigureAwait(false);
    }
#endif

}
