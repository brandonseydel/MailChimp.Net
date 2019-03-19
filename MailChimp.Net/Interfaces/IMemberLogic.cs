// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IMemberLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    /// <summary>
    /// The MemberLogic interface.
    /// </summary>
    public interface IMemberLogic
	{
		/// <summary>
		/// The add or update async.
		/// </summary>
		/// <param name="listId">
		/// The list id.
		/// </param>
		/// <param name="member">
		/// The member.
		/// </param>
		/// <returns>
		/// The <see cref="Task"/>.
		/// </returns>
		Task<Member> AddOrUpdateAsync(string listId, Member member, IList<MarketingPermissionText> marketingPermissions = null);
        
	    /// <summary>
	    /// Search the account or a specific list for members that match the specified query terms.
	    /// </summary>
	    /// <param name="request"></param>
	    /// <returns>
	    /// The <see cref="Task"/>.
	    /// </returns>
	    Task<MemberSearchResult> SearchAsync(MemberSearchRequest request);

        /// <summary>
        /// The delete async.
        /// </summary>
        /// <param name="listId">
        /// The list id.
        /// </param>
        /// <param name="emailAddressOrHash">
        /// The email address.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task DeleteAsync(string listId, string emailAddressOrHash);

        /// <summary>
        /// The permanent delete async.
        /// </summary>
        /// <param name="listId">
        /// The list id.
        /// </param>
        /// <param name="emailAddressOrHash">
        /// The email address.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task PermanentDeleteAsync(string listId, string emailAddressOrHash);
		
		/// <summary>
		/// Gets the activities for a specific list
		/// </summary>
		/// <param name="listId"></param>
		/// <param name="emailAddressOrHash"></param>
		/// <param name="request"></param>
		/// <returns></returns>
		Task<IEnumerable<Activity>> GetActivitiesAsync(string listId, string emailAddressOrHash, BaseRequest request = null);

		/// <summary>
		/// Gets the tags asynchronous.
		/// </summary>
		/// <param name="listId">The list identifier.</param>
		/// <param name="emailAddressOrHash">The email address or hash.</param>
		/// <param name="request">The request.</param>
		/// <returns></returns>
		Task<IEnumerable<MemberTag>> GetTagsAsync(string listId, string emailAddressOrHash, BaseRequest request = null);

        /// <summary>
        /// The get all async.
        /// </summary>
        /// <param name="listId">
        /// The list id.
        /// </param>
        /// <param name="memberRequest"></param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<Member>> GetAllAsync(string listId, MemberRequest memberRequest = null);

        /// <summary>
        /// Get the total number of members in the list
        /// </summary>
        /// <param name="listId"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        Task<int> GetTotalItems(string listId, Status? status);

        /// <summary>
		/// Get the total number of members in a list based on a MemberRequest model
		/// </summary>
		/// <param name="listId"></param>
		/// <param name="memberRequest"></param>
		/// <returns></returns>
        Task<int> GetTotalItemsByRequest(string listId, MemberRequest memberRequest);

        /// <summary>
        /// The get async.
        /// </summary>
        /// <param name="listId">
        /// The list id.
        /// </param>
        /// <param name="emailAddressOrHash">
        /// The email address.
        /// </param>
        /// <param name="request"></param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<Member> GetAsync(string listId, string emailAddressOrHash, BaseRequest request = null);

		/// <summary>
		/// The check if exists async.
		/// </summary>
		/// <param name="listId">
		/// The list id.
		/// </param>
		/// <param name="emailAddressOrHash">
		/// </param>
		/// <param name="request"></param>
		/// The email address.
		/// <returns>
		/// The <see cref="Task"/>.
		/// </returns>
		Task<bool> ExistsAsync(string listId, string emailAddressOrHash, BaseRequest request = null, bool falseIfUnsubscribed = true);

		/// <exception cref="ArgumentNullException"><paramref>
		///         <name>uriString</name>
		///     </paramref>
		///     is null. </exception>
		/// <exception cref="UriFormatException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.FormatException" />, instead.<paramref name="uriString" /> is empty.-or- The scheme specified in <paramref name="uriString" /> is not correctly formed. See <see cref="M:System.Uri.CheckSchemeName(System.String)" />.-or- <paramref name="uriString" /> contains too many slashes.-or- The password specified in <paramref name="uriString" /> is not valid.-or- The host name specified in <paramref name="uriString" /> is not valid.-or- The file name specified in <paramref name="uriString" /> is not valid. -or- The user name specified in <paramref name="uriString" /> is not valid.-or- The host or authority name specified in <paramref name="uriString" /> cannot be terminated by backslashes.-or- The port number specified in <paramref name="uriString" /> is not valid or cannot be parsed.-or- The length of <paramref name="uriString" /> exceeds 65519 characters.-or- The length of the scheme specified in <paramref name="uriString" /> exceeds 1023 characters.-or- There is an invalid character sequence in <paramref name="uriString" />.-or- The MS-DOS path specified in <paramref name="uriString" /> must start with c:\\.</exception>
		/// <exception cref="InvalidOperationException">This member belongs to a type that is loaded into the reflection-only context. See How to: Load Assemblies into the Reflection-Only Context.</exception>
		/// <exception cref="MailChimpException">
		/// Custom Mail Chimp Exception
		/// </exception>
		/// <exception cref="NotSupportedException"><paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception>
		/// <exception cref="TypeLoadException">A custom attribute type cannot be loaded. </exception>
		/// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
		Task<MemberResponse> GetResponseAsync(string listId, MemberRequest memberRequest = null);

		string Hash(string emailAddress);
	}
}
