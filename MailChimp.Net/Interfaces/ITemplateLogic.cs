// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ITemplateLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    /// <summary>
    ///     The TemplateLogic interface.
    /// </summary>
    public interface ITemplateLogic
    {
        /// <summary>
        ///     The get all async.
        /// </summary>
        /// <param name="request">
        ///     The request.
        /// </param>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        Task<IEnumerable<Template>> GetAllAsync(TemplateRequest request = null);

        Task<Template> CreateAsync(string name, string folderId, string html);
        Task<object> GetDefaultContentAsync(string templateId, BaseRequest request = null);

        /// <summary>
        ///     The get async.
        /// </summary>
        /// <param name="templateId">
        ///     The template id.
        /// </param>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        Task<Template> GetAsync(int templateId);

        /// <summary>
        ///     The get all async.
        /// </summary>
        /// <param name="request">
        ///     The request.
        /// </param>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        ///     <paramref>
        ///         <name>uriString</name>
        ///     </paramref>
        ///     is null.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Enlarging the value of this instance would exceed
        ///     <see cref="P:System.Text.StringBuilder.MaxCapacity" />.
        /// </exception>
        /// <exception cref="UriFormatException">
        ///     In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception,
        ///     <see cref="T:System.FormatException" />, instead.
        ///     <paramref>
        ///         <name>uriString</name>
        ///     </paramref>
        ///     is empty.-or- The scheme specified in
        ///     <paramref>
        ///         <name>uriString</name>
        ///     </paramref>
        ///     is not correctly formed. See <see cref="M:System.Uri.CheckSchemeName(System.String)" />.-or-
        ///     <paramref name="uriString" /> contains too many slashes.-or- The password specified in
        ///     <paramref>
        ///         <name>uriString</name>
        ///     </paramref>
        ///     is not valid.-or- The host name specified in <paramref name="uriString" /> is not valid.-or- The file name
        ///     specified in <paramref name="uriString" /> is not valid. -or- The user name specified in
        ///     <paramref>
        ///         <name>uriString</name>
        ///     </paramref>
        ///     is not valid.-or- The host or authority name specified in <paramref name="uriString" /> cannot be terminated by
        ///     backslashes.-or- The port number specified in <paramref name="uriString" /> is not valid or cannot be parsed.-or-
        ///     The length of
        ///     <paramref>
        ///         <name>uriString</name>
        ///     </paramref>
        ///     exceeds 65519 characters.-or- The length of the scheme specified in <paramref name="uriString" /> exceeds 1023
        ///     characters.-or- There is an invalid character sequence in
        ///     <paramref>
        ///         <name>uriString</name>
        ///     </paramref>
        ///     .-or- The MS-DOS path specified in
        ///     <paramref>
        ///         <name>uriString</name>
        ///     </paramref>
        ///     must start with c:\\.
        /// </exception>
        /// <exception cref="NotSupportedException">
        ///     <paramref>
        ///         <name>element</name>
        ///     </paramref>
        ///     is not a constructor, method, property, event, type, or field.
        /// </exception>
        /// <exception cref="MailChimpException">
        ///     Custom Mail Chimp Exception
        /// </exception>
        /// <exception cref="TypeLoadException">A custom attribute type cannot be loaded. </exception>
        Task<TemplateResponse> GetResponseAsync(TemplateRequest request = null);

        /// <summary>
        ///     The delete async.
        /// </summary>
        /// <param name="templateId">
        ///     The template id.
        /// </param>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        ///     <paramref>
        ///         <name>uriString</name>
        ///     </paramref>
        ///     is null.
        /// </exception>
        /// <exception cref="ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
        /// <exception cref="MailChimpException">
        ///     Custom Mail Chimp Exception
        /// </exception>
        /// <exception cref="UriFormatException">
        ///     In the .NET for Windows Store apps or the Portable Class Library, catch the base
        ///     class exception, <see cref="T:System.FormatException" />, instead.<paramref name="uriString" /> is empty.-or- The
        ///     scheme specified in <paramref name="uriString" /> is not correctly formed. See
        ///     <see cref="M:System.Uri.CheckSchemeName(System.String)" />.-or- <paramref name="uriString" /> contains too many
        ///     slashes.-or- The password specified in <paramref name="uriString" /> is not valid.-or- The host name specified in
        ///     <paramref name="uriString" /> is not valid.-or- The file name specified in <paramref name="uriString" /> is not
        ///     valid. -or- The user name specified in <paramref name="uriString" /> is not valid.-or- The host or authority name
        ///     specified in <paramref name="uriString" /> cannot be terminated by backslashes.-or- The port number specified in
        ///     <paramref name="uriString" /> is not valid or cannot be parsed.-or- The length of <paramref name="uriString" />
        ///     exceeds 65519 characters.-or- The length of the scheme specified in <paramref name="uriString" /> exceeds 1023
        ///     characters.-or- There is an invalid character sequence in <paramref name="uriString" />.-or- The MS-DOS path
        ///     specified in <paramref name="uriString" /> must start with c:\\.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     The request message was already sent by the
        ///     <see cref="T:System.Net.Http.HttpClient" /> instance.
        /// </exception>
        Task DeleteAsync(int templateId);

        Task<Template> UpdateAsync(int templateId, string name, string folderId, string html);


        /// <summary>
        ///     The get async.
        /// </summary>
        /// <param name="templateId">
        ///     The template id.
        /// </param>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        [Obsolete("TemplateId is officially declared as int.")]
        Task<Template> GetAsync(string templateId);

        /// <summary>
        ///     The delete async.
        /// </summary>
        /// <param name="templateId">
        ///     The template id.
        /// </param>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        ///     <paramref>
        ///         <name>uriString</name>
        ///     </paramref>
        ///     is null.
        /// </exception>
        /// <exception cref="ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
        /// <exception cref="MailChimpException">
        ///     Custom Mail Chimp Exception
        /// </exception>
        /// <exception cref="UriFormatException">
        ///     In the .NET for Windows Store apps or the Portable Class Library, catch the base
        ///     class exception, <see cref="T:System.FormatException" />, instead.<paramref name="uriString" /> is empty.-or- The
        ///     scheme specified in <paramref name="uriString" /> is not correctly formed. See
        ///     <see cref="M:System.Uri.CheckSchemeName(System.String)" />.-or- <paramref name="uriString" /> contains too many
        ///     slashes.-or- The password specified in <paramref name="uriString" /> is not valid.-or- The host name specified in
        ///     <paramref name="uriString" /> is not valid.-or- The file name specified in <paramref name="uriString" /> is not
        ///     valid. -or- The user name specified in <paramref name="uriString" /> is not valid.-or- The host or authority name
        ///     specified in <paramref name="uriString" /> cannot be terminated by backslashes.-or- The port number specified in
        ///     <paramref name="uriString" /> is not valid or cannot be parsed.-or- The length of <paramref name="uriString" />
        ///     exceeds 65519 characters.-or- The length of the scheme specified in <paramref name="uriString" /> exceeds 1023
        ///     characters.-or- There is an invalid character sequence in <paramref name="uriString" />.-or- The MS-DOS path
        ///     specified in <paramref name="uriString" /> must start with c:\\.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     The request message was already sent by the
        ///     <see cref="T:System.Net.Http.HttpClient" /> instance.
        /// </exception>
        [Obsolete("TemplateId is officially declared as int.")]
        Task DeleteAsync(string templateId);

        [Obsolete("TemplateId is officially declared as int.")]
        Task<Template> UpdateAsync(string templateId, string name, string folderId, string html);

    }
}