// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AutomationLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;
#pragma warning disable 1584,1711,1572,1581,1580

namespace MailChimp.Net.Logic;

/// <summary>
/// The automation logic.
/// </summary>
internal class AutomationLogic : BaseLogic, IAutomationLogic
{

    public AutomationLogic(MailChimpOptions mailChimpConfiguration, CancellationToken cancellationToken = default)
        : base(mailChimpConfiguration)
    {
    }

    /// <summary>
    /// The get all async.
    /// </summary>
    /// <param name="request">
    /// The request.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException"><paramref>
    ///         <name>uriString</name>
    ///     </paramref>
    ///     is null. </exception>
    /// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
    /// <exception cref="UriFormatException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.FormatException" />, instead.<paramref name="uriString" /> is empty.-or- The scheme specified in <paramref name="uriString" /> is not correctly formed. See <see cref="M:System.Uri.CheckSchemeName(System.String)" />.-or- <paramref name="uriString" /> contains too many slashes.-or- The password specified in <paramref name="uriString" /> is not valid.-or- The host name specified in <paramref name="uriString" /> is not valid.-or- The file name specified in <paramref name="uriString" /> is not valid. -or- The user name specified in <paramref name="uriString" /> is not valid.-or- The host or authority name specified in <paramref name="uriString" /> cannot be terminated by backslashes.-or- The port number specified in <paramref name="uriString" /> is not valid or cannot be parsed.-or- The length of <paramref name="uriString" /> exceeds 65519 characters.-or- The length of the scheme specified in <paramref name="uriString" /> exceeds 1023 characters.-or- There is an invalid character sequence in <paramref name="uriString" />.-or- The MS-DOS path specified in <paramref name="uriString" /> must start with c:\\.</exception>
    /// <exception cref="NotSupportedException"><paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception>
    /// <exception cref="MailChimpException">
    /// Custom Mail Chimp Exception
    /// </exception>
    /// <exception cref="TypeLoadException">A custom attribute type cannot be loaded. </exception>
    public async Task<IEnumerable<Automation>> GetAllAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default) 
        => (await GetResponseAsync(request, cancellationToken).ConfigureAwait(false))?.Automations;


    /// <summary>
    /// The get all async.
    /// </summary>
    /// <param name="request">
    /// The request.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException"><paramref>
    ///         <name>uriString</name>
    ///     </paramref>
    ///     is null. </exception>
    /// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
    /// <exception cref="UriFormatException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.FormatException" />, instead.<paramref name="uriString" /> is empty.-or- The scheme specified in <paramref name="uriString" /> is not correctly formed. See <see cref="M:System.Uri.CheckSchemeName(System.String)" />.-or- <paramref name="uriString" /> contains too many slashes.-or- The password specified in <paramref name="uriString" /> is not valid.-or- The host name specified in <paramref name="uriString" /> is not valid.-or- The file name specified in <paramref name="uriString" /> is not valid. -or- The user name specified in <paramref name="uriString" /> is not valid.-or- The host or authority name specified in <paramref name="uriString" /> cannot be terminated by backslashes.-or- The port number specified in <paramref name="uriString" /> is not valid or cannot be parsed.-or- The length of <paramref name="uriString" /> exceeds 65519 characters.-or- The length of the scheme specified in <paramref name="uriString" /> exceeds 1023 characters.-or- There is an invalid character sequence in <paramref name="uriString" />.-or- The MS-DOS path specified in <paramref name="uriString" /> must start with c:\\.</exception>
    /// <exception cref="NotSupportedException"><paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception>
    /// <exception cref="MailChimpException">
    /// Custom Mail Chimp Exception
    /// </exception>
    /// <exception cref="TypeLoadException">A custom attribute type cannot be loaded. </exception>
    public async Task<AutomationResponse> GetResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
    {
        request ??= new QueryableBaseRequest
        {
            Limit = _limit
        };

        using var client = CreateMailClient("automations");
        var response = await client.GetAsync(request.ToQueryString(), cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        var automationResponse = await response.Content.ReadAsAsync<AutomationResponse>().ConfigureAwait(false);
        return automationResponse;
    }


    /// <summary>
    /// The get async.
    /// </summary>
    /// <param name="workflowId">
    /// The workflow id.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException"><paramref>
    ///         <name>uriString</name>
    ///     </paramref>
    ///     is null. </exception>
    /// <exception cref="UriFormatException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.FormatException" />, instead.<paramref name="uriString" /> is empty.-or- The scheme specified in <paramref name="uriString" /> is not correctly formed. See <see cref="M:System.Uri.CheckSchemeName(System.String)" />.-or- <paramref name="uriString" /> contains too many slashes.-or- The password specified in <paramref name="uriString" /> is not valid.-or- The host name specified in <paramref name="uriString" /> is not valid.-or- The file name specified in <paramref name="uriString" /> is not valid. -or- The user name specified in <paramref name="uriString" /> is not valid.-or- The host or authority name specified in <paramref name="uriString" /> cannot be terminated by backslashes.-or- The port number specified in <paramref name="uriString" /> is not valid or cannot be parsed.-or- The length of <paramref name="uriString" /> exceeds 65519 characters.-or- The length of the scheme specified in <paramref name="uriString" /> exceeds 1023 characters.-or- There is an invalid character sequence in <paramref name="uriString" />.-or- The MS-DOS path specified in <paramref name="uriString" /> must start with c:\\.</exception>
    /// <exception cref="MailChimpException">
    /// Custom Mail Chimp Exception
    /// </exception>
    public async Task<Automation> GetAsync(string workflowId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient("automations/");
        var response = await client.GetAsync(workflowId, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        return await response.Content.ReadAsAsync<Automation>().ConfigureAwait(false);
    }

    /// <summary>
    /// The update async.
    /// </summary>
    /// <param name="workflowId">
    /// The workflow id.
    /// </param>
    /// <param name="automation">
    /// The automation.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException"><paramref>
    ///         <name>uriString</name>
    ///     </paramref>
    ///     is null. </exception>
    /// <exception cref="MailChimpException">
    /// Custom Mail Chimp Exception
    /// </exception>
    /// <exception cref="UriFormatException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.FormatException" />, instead.<paramref name="uriString" /> is empty.-or- The scheme specified in <paramref name="uriString" /> is not correctly formed. See <see cref="M:System.Uri.CheckSchemeName(System.String)" />.-or- <paramref name="uriString" /> contains too many slashes.-or- The password specified in <paramref name="uriString" /> is not valid.-or- The host name specified in <paramref name="uriString" /> is not valid.-or- The file name specified in <paramref name="uriString" /> is not valid. -or- The user name specified in <paramref name="uriString" /> is not valid.-or- The host or authority name specified in <paramref name="uriString" /> cannot be terminated by backslashes.-or- The port number specified in <paramref name="uriString" /> is not valid or cannot be parsed.-or- The length of <paramref name="uriString" /> exceeds 65519 characters.-or- The length of the scheme specified in <paramref name="uriString" /> exceeds 1023 characters.-or- There is an invalid character sequence in <paramref name="uriString" />.-or- The MS-DOS path specified in <paramref name="uriString" /> must start with c:\\.</exception>
    public async Task<Automation> UpdateAsync(string workflowId, Automation automation, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient("automations/");
        var response = await client.PatchAsJsonAsync($"{workflowId}", automation, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

        return await response.Content.ReadAsAsync<Automation>().ConfigureAwait(false);
    }

    /// <summary>
    /// The pause async.
    /// </summary>
    /// <param name="workflowId">
    /// The workflow id.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException"><paramref>
    ///         <name>uriString</name>
    ///     </paramref>
    ///     is null. </exception>
    /// <exception cref="UriFormatException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.FormatException" />, instead.<paramref name="uriString" /> is empty.-or- The scheme specified in <paramref name="uriString" /> is not correctly formed. See <see cref="M:System.Uri.CheckSchemeName(System.String)" />.-or- <paramref name="uriString" /> contains too many slashes.-or- The password specified in <paramref name="uriString" /> is not valid.-or- The host name specified in <paramref name="uriString" /> is not valid.-or- The file name specified in <paramref name="uriString" /> is not valid. -or- The user name specified in <paramref name="uriString" /> is not valid.-or- The host or authority name specified in <paramref name="uriString" /> cannot be terminated by backslashes.-or- The port number specified in <paramref name="uriString" /> is not valid or cannot be parsed.-or- The length of <paramref name="uriString" /> exceeds 65519 characters.-or- The length of the scheme specified in <paramref name="uriString" /> exceeds 1023 characters.-or- There is an invalid character sequence in <paramref name="uriString" />.-or- The MS-DOS path specified in <paramref name="uriString" /> must start with c:\\.</exception>
    /// <exception cref="MailChimpException">
    /// Custom Mail Chimp Exception
    /// </exception>
    public async Task PauseAsync(string workflowId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient("automations/");
        var response = await client.GetAsync($"{workflowId}/actions/pause-all-emails", cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
    }

    /// <summary>
    /// The start async.
    /// </summary>
    /// <param name="workflowId">
    /// The workflow id.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException"><paramref>
    ///         <name>uriString</name>
    ///     </paramref>
    ///     is null. </exception>
    /// <exception cref="UriFormatException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.FormatException" />, instead.<paramref name="uriString" /> is empty.-or- The scheme specified in <paramref name="uriString" /> is not correctly formed. See <see cref="M:System.Uri.CheckSchemeName(System.String)" />.-or- <paramref name="uriString" /> contains too many slashes.-or- The password specified in <paramref name="uriString" /> is not valid.-or- The host name specified in <paramref name="uriString" /> is not valid.-or- The file name specified in <paramref name="uriString" /> is not valid. -or- The user name specified in <paramref name="uriString" /> is not valid.-or- The host or authority name specified in <paramref name="uriString" /> cannot be terminated by backslashes.-or- The port number specified in <paramref name="uriString" /> is not valid or cannot be parsed.-or- The length of <paramref name="uriString" /> exceeds 65519 characters.-or- The length of the scheme specified in <paramref name="uriString" /> exceeds 1023 characters.-or- There is an invalid character sequence in <paramref name="uriString" />.-or- The MS-DOS path specified in <paramref name="uriString" /> must start with c:\\.</exception>
    /// <exception cref="MailChimpException">
    /// Custom Mail Chimp Exception
    /// </exception>
    public async Task StartAsync(string workflowId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient("automations/");
        var response = await client.GetAsync($"{workflowId}/actions/start-all-emails", cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
    }
}