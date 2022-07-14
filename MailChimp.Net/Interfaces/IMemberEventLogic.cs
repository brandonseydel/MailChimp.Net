using System.Threading.Tasks;
using MailChimp.Net.Core.Requests;
using MailChimp.Net.Core.Responses;

namespace MailChimp.Net.Interfaces
{
    /// <summary>Interface for member event logic.</summary>
    public interface IMemberEventLogic
    {
        /// <summary>Gets events asynchronously.</summary>
        /// <param name="listId">Identifier for the list.</param>
        /// <param name="subscriberId">Identifier for the subscriber.</param>
        /// <param name="memberEventRequest">(Optional) The member event request.</param>
        /// <returns>An asynchronous result that yields the events.</returns>
        Task<MemberEventResponse> GetEventsAsync(string listId, string subscriberId, MemberEventRequest memberEventRequest = null);

        /// <summary>Gets the events.</summary>
        /// <param name="listId">Identifier for the list.</param>
        /// <param name="subscriberId">Identifier for the subscriber.</param>
        /// <param name="memberEventRequest">(Optional) The member event request.</param>
        /// <returns>The events.</returns>
        MemberEventResponse GetEvents(string listId, string subscriberId, MemberEventRequest memberEventRequest = null);

        /// <summary>Adds an event asynchronously.</summary>
        /// <param name="listId">Identifier for the list.</param>
        /// <param name="subscriberId">Identifier for the subscriber.</param>
        /// <param name="memberEvent">The member event.</param>
        /// <returns>An asynchronous result that yields the add event.</returns>
        Task<bool> AddEventAsync(string listId, string subscriberId, MemberEvent memberEvent);

        /// <summary>Adds an event.</summary>
        /// <param name="listId">Identifier for the list.</param>
        /// <param name="subscriberId">Identifier for the subscriber.</param>
        /// <param name="memberEvent">The member event.</param>
        /// <returns>True if it succeeds, false if it fails.</returns>
        bool AddEvent(string listId, string subscriberId, MemberEvent memberEvent);
    }
}
