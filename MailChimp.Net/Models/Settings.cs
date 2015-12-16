using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Setting
    {

        [JsonProperty("subject_line")]
        public string SubjectLine { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("from_name")]
        public string FromName { get; set; }

        [JsonProperty("reply_to")]
        public string ReplyTo { get; set; }

        [JsonProperty("use_conversation")]
        public bool UseConversation { get; set; }

        [JsonProperty("to_name")]
        public string ToName { get; set; }

        [JsonProperty("folder_id")]
        public string FolderId { get; set; }

        [JsonProperty("authenticate")]
        public bool Authenticate { get; set; }

        [JsonProperty("auto_footer")]
        public bool AutoFooter { get; set; }

        [JsonProperty("inline_css")]
        public bool InlineCss { get; set; }

        [JsonProperty("auto_tweet")]
        public bool AutoTweet { get; set; }

        [JsonProperty("fb_comments")]
        public bool FbComments { get; set; }

        [JsonProperty("timewarp")]
        public bool Timewarp { get; set; }

        [JsonProperty("template_id")]
        public int TemplateId { get; set; }

        [JsonProperty("drag_and_drop")]
        public bool DragAndDrop { get; set; }
    }
}