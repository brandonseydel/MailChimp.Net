// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CampaignStatus.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MailChimp.Net.Core;

/// <summary>
/// Wrapper around HttpClient.  
/// </summary>
public class MailChimpHttpClient : IDisposable
{
    private static readonly JsonSerializerSettings JsonSettings = new()
    {
        NullValueHandling = NullValueHandling.Ignore
    };

    private readonly MailChimpOptions _options;
    private readonly HttpClient _httpClient;
    private readonly string _resource;

    public MailChimpHttpClient(HttpClient httpClient, MailChimpOptions options, string resource)
    {
        _httpClient = httpClient;
        _options = options;

        if (resource != null && resource.StartsWith("/"))
        {
            resource = resource.Substring(1);
        }

        _resource = resource;
    }

    public void Dispose()
    {
#if !HTTP_CLIENT_FACTORY
        _httpClient.Dispose();
#endif
    }


    /// <summary>
    /// Delete request
    /// </summary> 
    /// <param name="requestUri">
    /// The request uri.
    /// </param>     
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    public Task<HttpResponseMessage> DeleteAsync(string requestUri, CancellationToken cancellationToken) 
        => SendAsync(HttpMethod.Delete, requestUri, contentOrNull: null, cancellationToken);

    /// <summary>
    /// Get request
    /// </summary> 
    /// <param name="requestUri">
    /// The request uri.
    /// </param>     
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    public Task<HttpResponseMessage> GetAsync(string requestUri, CancellationToken cancellationToken) 
        => SendAsync(HttpMethod.Get, requestUri, contentOrNull: null, cancellationToken);

    /// <summary>
    /// Post request
    /// </summary> 
    /// <param name="requestUri">
    /// The request uri.
    /// </param>   
    /// <param name="httpContent">
    /// The httpContent
    /// </param> 
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    public Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent httpContent, CancellationToken cancellationToken) 
        => SendAsync(HttpMethod.Post, requestUri, contentOrNull: httpContent, cancellationToken);

    /// <summary>
    /// The put as json async.
    /// </summary> 
    /// <param name="requestUri">
    /// The request uri.
    /// </param>
    /// <param name="value">
    /// The value.
    /// </param>
    /// <param name="settings"></param>
    /// <typeparam name="T">
    /// </typeparam>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    public Task<HttpResponseMessage> PutAsJsonAsync<T>(string requestUri, T value, CancellationToken cancellationToken, JsonSerializerSettings settings = null) 
        => SendAsync(HttpMethod.Put, requestUri, GetStringContent(value, settings), cancellationToken);

    /// <summary>
    /// The patch as json async.
    /// </summary>  
    /// <param name="requestUri">
    /// The request uri.
    /// </param>
    /// <param name="value">
    /// The value.
    /// </param>
    /// <param name="settings"></param>
    /// <typeparam name="T">
    /// </typeparam>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    public Task<HttpResponseMessage> PatchAsJsonAsync<T>(string requestUri, T value, CancellationToken cancellationToken, JsonSerializerSettings settings = null) 
        => SendAsync(new HttpMethod("PATCH"), requestUri, GetStringContent(value, settings), cancellationToken);

    /// <summary>
    /// PostAsJsonAsync
    /// </summary>     
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
    public Task<HttpResponseMessage> PostAsJsonAsync<T>(string requestUri, T value, CancellationToken cancellationToken, JsonSerializerSettings settings = null) 
        => SendAsync(HttpMethod.Post, requestUri, GetStringContent(value, settings), cancellationToken);

    private StringContent GetStringContent<T>(T value, JsonSerializerSettings settings) 
        => new StringContent(JsonConvert.SerializeObject(value, settings ?? JsonSettings), Encoding.UTF8, "application/json");

    private Task<HttpResponseMessage> SendAsync(HttpMethod method, string requestUri, HttpContent contentOrNull, CancellationToken cancellationToken)
    {
        var request = new HttpRequestMessage(method, _resource + requestUri);
        if (method.Method == "PATCH")
        {
            request.Headers.ExpectContinue = false;
        }
        request.Headers.Add("Authorization", _options.AuthHeader);
        if (contentOrNull != null)
        {
            request.Content = contentOrNull;
        }
        return _httpClient.SendAsync(request, cancellationToken);
    }

}
