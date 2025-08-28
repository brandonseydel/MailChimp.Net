// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MessageLogic.cs" company="Brandon Seydel">
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

// ReSharper disable UnusedMember.Local
namespace MailChimp.Net.Logic;

/// <summary>
/// The message logic.
/// </summary>
internal class MessageLogic : BaseLogic, IMessageLogic
{

    public MessageLogic(MailChimpOptions mailChimpConfiguration)
        : base(mailChimpConfiguration)
    {
    }

    /// <summary>
    /// The add async.
    /// </summary>
    /// <param name="conversationId">
    /// The conversation id.
    /// </param>
    /// <param name="message">
    /// The message.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    public async Task<Message> AddAsync(string conversationId, Message message, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient("conversations/");
        var response = await client.PutAsJsonAsync($"{conversationId}", message, cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

        return await response.Content.ReadAsAsync<Message>().ConfigureAwait(false);
    }

    /// <summary>
    /// The get all async.
    /// </summary>
    /// <param name="conversationId">
    /// The conversation id.
    /// </param>
    /// <param name="request">
    /// The request.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    public async Task<IEnumerable<Message>> GetAllAsync(string conversationId, MessageRequest request = null, CancellationToken cancellationToken = default) 
        => (await GetResponseAsync(conversationId, request, cancellationToken).ConfigureAwait(false))?.Messages;

    /// <summary>
    /// The get all async.
    /// </summary>
    /// <param name="conversationId">
    /// The conversation id.
    /// </param>
    /// <param name="request">
    /// The request.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    public async Task<MessageResponse> GetResponseAsync(string conversationId, MessageRequest request = null, CancellationToken cancellationToken = default)
    {

        using var client = CreateMailClient($"conversations/{request?.ToQueryString()}");
        var response = await client.GetAsync($"{conversationId}/messages", cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

        var listResponse = await response.Content.ReadAsAsync<MessageResponse>().ConfigureAwait(false);
        return listResponse;
    }


    /// <summary>
    /// The get async.
    /// </summary>
    /// <param name="conversationId">
    /// The conversation id.
    /// </param>
    /// <param name="messageId">
    /// The message id.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    public async Task<Message> GetAsync(string conversationId, string messageId, CancellationToken cancellationToken = default)
    {
        using var client = CreateMailClient("conversations/");
        var response = await client.GetAsync($"{conversationId}/messages/{messageId}", cancellationToken).ConfigureAwait(false);
        await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

        return await response.Content.ReadAsAsync<Message>().ConfigureAwait(false);
    }
}