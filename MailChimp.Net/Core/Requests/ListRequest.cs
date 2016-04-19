// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ListRequest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace MailChimp.Net.Core
{
    /// <summary>
    /// The list request.
    /// </summary>
    public class ListRequest : QueryableBaseRequest
    {
        /// <summary>
        /// Gets or sets the email type.
        /// </summary>
        [QueryString("email_type_option")]
        public bool? EmailType { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [QueryString("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the notify on subscrbe.
        /// </summary>
        [QueryString("notify_on_subscribe")]
        public string NotifyOnSubscrbe { get; set; }

        /// <summary>
        /// Gets or sets the notify on unsubscrbibe.
        /// </summary>
        [QueryString("notify_on_unsubscribe")]
        public string NotifyOnUnsubscrbibe { get; set; }

        /// <summary>
        /// Gets or sets the permission reminder.
        /// </summary>
        [QueryString("permission_reminder")]
        public string PermissionReminder { get; set; }

        /// <summary>
        /// Gets or sets the user archive bar.
        /// </summary>
        [QueryString("use_archive_bar")]
        public bool? UserArchiveBar { get; set; }

        /// <summary>
        /// Gets or sets the visibility.
        /// </summary>
        [QueryString("visibility")]
        public string Visibility { get; set; }
    }
}