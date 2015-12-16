namespace MailChimp.Net.Core
{
    public class ListRequest : BaseRequest
    {
        [QueryString("name")]
        public string Name { get; set; }
        [QueryString("permission_reminder")]
        public string PermissionReminder { get; set; }
        [QueryString("use_archive_bar")]
        public bool? UserArchiveBar { get; set; }
        [QueryString("notify_on_subscribe")]
        public string NotifyOnSubscrbe { get; set; }
        [QueryString("notify_on_unsubscribe")]
        public string NotifyOnUnsubscrbibe { get; set; }
        [QueryString("email_type_option")]
        public bool? EmailType { get; set; }
        [QueryString("visibility")]
        public string Visibility { get; set; }
    }
}