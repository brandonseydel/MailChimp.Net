// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFeedbackLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;

using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces;

/// <summary>
/// The FeedbackLogic interface.
/// </summary>
public interface IFeedbackLogic
{
    /// <summary>
    /// The add or update async.
    /// </summary>
    /// <param name="campaignId">
    /// The campaign id.
    /// </param>
    /// <param name="feedback">
    /// The feedback.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    Task<Feedback> AddOrUpdateAsync(string campaignId, Feedback feedback);

    /// <summary>
    /// The delete async.
    /// </summary>
    /// <param name="campaignId">
    /// The campaign id.
    /// </param>
    /// <param name="feedbackId">
    /// The feedback id.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    Task DeleteAsync(string campaignId, string feedbackId);

    /// <summary>
    /// The get all async.
    /// </summary>
    /// <param name="campaignId">
    /// The campaign id.
    /// </param>
    /// <param name="request">
    /// The request.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    Task<IEnumerable<Feedback>> GetAllAsync(string campaignId, FeedbackRequest request = null);

    /// <summary>
    /// The get async.
    /// </summary>
    /// <param name="campaignId">
    /// The campaign id.
    /// </param>
    /// <param name="feedbackId">
    /// The feedback id.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    Task<Feedback> GetAsync(string campaignId, string feedbackId);

    /// <summary>
    /// The get all async.
    /// </summary>
    /// <param name="campaignId">
    /// The campaign id.
    /// </param>
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
    /// <exception cref="UriFormatException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.FormatException" />, instead.<paramref name="uriString" /> is empty.-or- The scheme specified in <paramref name="uriString" /> is not correctly formed. See <see cref="M:System.Uri.CheckSchemeName(System.String)" />.-or- <paramref name="uriString" /> contains too many slashes.-or- The password specified in <paramref name="uriString" /> is not valid.-or- The host name specified in <paramref name="uriString" /> is not valid.-or- The file name specified in <paramref name="uriString" /> is not valid. -or- The user name specified in <paramref name="uriString" /> is not valid.-or- The host or authority name specified in <paramref name="uriString" /> cannot be terminated by backslashes.-or- The port number specified in <paramref name="uriString" /> is not valid or cannot be parsed.-or- The length of <paramref name="uriString" /> exceeds 65519 characters.-or- The length of the scheme specified in <paramref name="uriString" /> exceeds 1023 characters.-or- There is an invalid character sequence in <paramref name="uriString" />.-or- The MS-DOS path specified in <paramref name="uriString" /> must start with c:\\.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
    /// <exception cref="MailChimpException">
    /// Custom Mail Chimp Exception
    /// </exception>
    /// <exception cref="NotSupportedException"><paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception>
    /// <exception cref="TypeLoadException">A custom attribute type cannot be loaded. </exception>
    Task<FeedBackResponse> GetResponseAsync(string campaignId, FeedbackRequest request = null);
}