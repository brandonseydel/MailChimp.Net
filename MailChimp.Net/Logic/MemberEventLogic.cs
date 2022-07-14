using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Core.Requests;
using MailChimp.Net.Core.Responses;
using MailChimp.Net.Interfaces;

namespace MailChimp.Net.Logic
{
    /// <summary>A member event logic.</summary>
    /// <seealso cref="T:MailChimp.Net.Core.BaseLogic"/>
    /// <seealso cref="T:MailChimp.Net.Interfaces.IMemberEventLogic"/>
    internal class MemberEventLogic : BaseLogic, IMemberEventLogic
    {
        /// <summary>URL of the base. Where {0} is list_id and {1} is subscriber_hash</summary>
        private const string BaseUrl = "/lists";

        /// <summary>Message describing the required parameter error.</summary>
        private const string RequiredParamErrorMessage = "A valid {0} must be provided.";

        public MemberEventLogic(MailChimpOptions mailChimpConfiguration)
            : base(mailChimpConfiguration)
        {
        }

        /// <summary>Gets events asynchronously.</summary>
        /// <exception cref="AggregateException">Thrown when either a <paramref name="listId"/> or <paramref name="subscriberId"/> are not provided.</exception>
        /// <param name="listId">Identifier for the list.</param>
        /// <param name="subscriberId">Identifier for the subscriber.</param>
        /// <param name="memberEventRequest">(Optional) The member event request.</param>
        /// <returns>An asynchronous result that yields the events.</returns>
        /// <seealso cref="M:MailChimp.Net.Interfaces.IMemberEventLogic.GetEventsAsync(string,string,MemberEventRequest)"/>
        public async Task<MemberEventResponse> GetEventsAsync(string listId, string subscriberId, MemberEventRequest memberEventRequest = null)
        {
            ValidateContractualParameters(listId, subscriberId, false);
            memberEventRequest = GetMemberRequestOrUseProvided(memberEventRequest);

            return await GetGETResponse(listId, subscriberId, memberEventRequest).ConfigureAwait(false);
        }

        /// <summary>Gets the events.</summary>
        /// <exception cref="AggregateException">Thrown when either a <paramref name="listId"/> or <paramref name="subscriberId"/> are not provided.</exception>
        /// <param name="listId">Identifier for the list.</param>
        /// <param name="subscriberId">Identifier for the subscriber.</param>
        /// <param name="memberEventRequest">(Optional) The member event request.</param>
        /// <returns>The events.</returns>
        public MemberEventResponse GetEvents(string listId, string subscriberId, MemberEventRequest memberEventRequest = null)
        {
            return GetEventsAsync(listId, subscriberId, memberEventRequest).GetAwaiter().GetResult();
        }

        /// <summary>Adds an event asynchronous.</summary>
        /// <exception cref="AggregateException">Thrown when either a <see cref="MemberEvent"/>, <paramref name="listId"/> or <paramref name="subscriberId"/> are not provided.</exception>
        /// <param name="listId">Identifier for the list.</param>
        /// <param name="subscriberId">Identifier for the subscriber.</param>
        /// <param name="memberEvent">The member event.</param>
        /// <returns>An asynchronous result that yields the add event.</returns>
        public async Task<bool> AddEventAsync(string listId, string subscriberId, MemberEvent memberEvent)
        {
            ValidateContractualParameters(listId, subscriberId, true, memberEvent);

            return await GetPOSTResponse(listId, subscriberId, memberEvent).ConfigureAwait(false);
        }

        /// <summary>Adds an event.</summary>
        /// <exception cref="AggregateException">Thrown when either a <see cref="MemberEvent"/>, <paramref name="listId"/> or <paramref name="subscriberId"/> are not provided.</exception>
        /// <param name="listId">Identifier for the list.</param>
        /// <param name="subscriberId">Identifier for the subscriber.</param>
        /// <param name="memberEvent">The member event.</param>
        /// <returns>True if it succeeds, false if it fails.</returns>
        public bool AddEvent(string listId, string subscriberId, MemberEvent memberEvent)
        {
            return AddEventAsync(listId, subscriberId, memberEvent).GetAwaiter().GetResult();
        }

        /// <summary>Gets member request or use provided.</summary>
        /// <param name="memberEventRequest">The member event request.</param>
        /// <returns>The member request or use provided.</returns>
        private MemberEventRequest GetMemberRequestOrUseProvided(MemberEventRequest memberEventRequest)
        {
            if (memberEventRequest == null)
            {
                memberEventRequest = new MemberEventRequest
                {
                    Limit = _limit
                };
            }

            return memberEventRequest;
        }

        /// <summary>Gets POST response.</summary>
        /// <param name="listId">Identifier for the list.</param>
        /// <param name="subscriberId">Identifier for the subscriber.</param>
        /// <param name="memberEvent">The member event.</param>
        /// <returns>An asynchronous result that yields the events post response.</returns>
        private async Task<bool> GetPOSTResponse(string listId, string subscriberId, MemberEvent memberEvent)
        {
            using (var client = CreateMailClient($"{BaseUrl}/"))
            {
                var response = await client.PostAsJsonAsync(GetRequestUrl(listId, subscriberId), memberEvent).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                return response.StatusCode == HttpStatusCode.NoContent;
            }
        }

        /// <summary>Gets GET response.</summary>
        /// <param name="listId">Identifier for the list.</param>
        /// <param name="subscriberId">Identifier for the subscriber.</param>
        /// <param name="memberEventRequest">The member event request.</param>
        /// <returns>An asynchronous result that yields the events get response.</returns>
        private async Task<MemberEventResponse> GetGETResponse(string listId, string subscriberId, MemberEventRequest memberEventRequest)
        {
            using (var client = CreateMailClient($"{BaseUrl}/"))
            {
                var response = await client.GetAsync(GetRequestUrl(listId, subscriberId, memberEventRequest)).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var listResponse = await response.Content.ReadAsAsync<MemberEventResponse>().ConfigureAwait(false);
                return listResponse;
            }
        }

        /// <summary>Validates the contractual parameters.</summary>
        /// <exception cref="AggregateException">Thrown when either <paramref name="listId"/> or <paramref name="subscriberId"/> are not provided.</exception>
        /// <param name="listId">Identifier for the list.</param>
        /// <param name="subscriberId">Identifier for the subscriber.</param>
        private static void ValidateContractualParameters(string listId, string subscriberId, bool validateMemberEvent, MemberEvent memberEvent = null)
        {
            var argumentOutOfRangeExceptions = new List<ArgumentOutOfRangeException>();

            if (string.IsNullOrWhiteSpace(listId))
            {
                argumentOutOfRangeExceptions.Add(new ArgumentOutOfRangeException(nameof(listId), string.Format(RequiredParamErrorMessage, nameof(String))));
            }

            if (string.IsNullOrWhiteSpace(subscriberId))
            {
                argumentOutOfRangeExceptions.Add(new ArgumentOutOfRangeException(nameof(subscriberId), string.Format(RequiredParamErrorMessage, nameof(String))));
            }

            if (validateMemberEvent && memberEvent == null)
            {
                argumentOutOfRangeExceptions.Add(new ArgumentOutOfRangeException(nameof(memberEvent), string.Format(RequiredParamErrorMessage, nameof(MemberEvent))));
            }

            if (argumentOutOfRangeExceptions.Count > 0)
            {
                throw new AggregateException(argumentOutOfRangeExceptions);
            }
        }

        /// <summary>Gets request URL.</summary>
        /// <param name="listId">Identifier for the list.</param>
        /// <param name="subscriberId">Identifier for the subscriber.</param>
        /// <returns>The request URL.</returns>
        private static string GetRequestUrl(string listId, string subscriberId)
        {
            return $"{listId}/members/{subscriberId}/events";
        }

        /// <summary>Gets request URL.</summary>
        /// <param name="listId">Identifier for the list.</param>
        /// <param name="subscriberId">Identifier for the subscriber.</param>
        /// <param name="memberEventRequest">The member event request.</param>
        /// <returns>The request URL.</returns>
        private static string GetRequestUrl(string listId, string subscriberId, MemberEventRequest memberEventRequest)
        {
            return $"{GetRequestUrl(listId, subscriberId)}{memberEventRequest.ToQueryString()}";
        }
    }
}
