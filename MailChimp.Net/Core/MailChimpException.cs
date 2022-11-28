// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MailChimpException.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using MailChimp.Net.Models;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The exception that comes back from Mail Chimp when an invalid operation has occured.
    /// </summary>
    public class MailChimpException : Exception
    {
        public MailChimpException(string prefix, MailChimpApiError apierror, HttpResponseMessage rawHttpResponseMessage = null) 
            : base((prefix != null ? $"{prefix} " : "")  +  formatMessage(apierror, rawHttpResponseMessage))
        {
            Detail = apierror.Detail;
            Title = apierror.Title;
            Type = apierror.Type;
            Status = apierror.Status;
            Instance = apierror.Instance;
            Errors = apierror.Errors;

            RawHttpResponseMessage = rawHttpResponseMessage;
        }
        public MailChimpException(MailChimpApiError apierror, HttpResponseMessage rawHttpResponseMessage = null) : this(null, apierror, rawHttpResponseMessage)
        {
        }

        private static string formatMessage(MailChimpApiError apierror, HttpResponseMessage rawHttpResponseMessage)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Title: {apierror.Title}");
            builder.AppendLine($"Type: {apierror.Type}");
            builder.AppendLine($"Status: {apierror.Status}");
            builder.AppendLine($"Instance: {apierror.Instance}");
            builder.AppendLine($"Detail: {apierror.Detail}");
            builder.AppendLine("Errors: " + string.Join(" : ", apierror.Errors.Select(x => x.Field + " " + x.Message)));
            if (rawHttpResponseMessage != null) 
                builder.AppendLine("Request URI:" + rawHttpResponseMessage.RequestMessage?.RequestUri);
            return builder.ToString();
        }

        private IDictionary _data;

        public List<MailChimpError> Errors { get; set; }

        /// <summary>
        /// Gets or Sets a human-readable explanation specific to this occurrence of the problem. Learn more about errors.
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// Gets or sets a string that identifies this specific occurrence of the problem. Please provide this ID when contacting support.
        /// </summary>
        public string Instance { get; set; }

        /// <summary>
        /// Gets or sets the HTTP status code (RFC2616, Section 6) generated by the origin server for this occurrence of the problem.
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets a short, human-readable summary of the problem type. It shouldn't change based on the occurrence of the problem, except for purposes of localization.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets an absolute URI that identifies the problem type. When dereferenced, it should provide human-readable documentation for the problem type.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets the raw http response message.
        /// </summary>
        public HttpResponseMessage RawHttpResponseMessage { get; set; }

        public override IDictionary Data
        {
            get
            {
                if (_data != null)
                    return _data;

                var data = base.Data;
                data["detail"] = Detail;
                data["title"] = Title;
                data["type"] = Type;
                data["status"] = Status;
                data["instance"] = Instance;
                data["errors"] = Errors;
#if NET_CORE || NETSTANDARD
                data["rawhttpresponsemessage"] = RawHttpResponseMessage;
#endif

                _data = data;
                return _data;
            }
        }
    }
}
