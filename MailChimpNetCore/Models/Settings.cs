// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Settings.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// The setting.
    /// </summary>
    public class Setting
    {
        /// <summary>
        /// Gets or sets a value indicating whether authenticate.
        /// </summary>
        [JsonProperty("authenticate")]
        public bool Authenticate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether auto footer.
        /// </summary>
        [JsonProperty("auto_footer")]
        public bool AutoFooter { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether auto tweet.
        /// </summary>
        [JsonProperty("auto_tweet")]
        public bool AutoTweet { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether drag and drop.
        /// </summary>
        [JsonProperty("drag_and_drop")]
        public bool DragAndDrop { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether fb comments.
        /// </summary>
        [JsonProperty("fb_comments")]
        public bool FbComments { get; set; }

        /// <summary>
        /// Gets or sets the folder id.
        /// </summary>
        [JsonProperty("folder_id")]
        public string FolderId { get; set; }

        /// <summary>
        /// Gets or sets the from name.
        /// </summary>
        [JsonProperty("from_name")]
        public string FromName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether inline css.
        /// </summary>
        [JsonProperty("inline_css")]
        public bool InlineCss { get; set; }

        /// <summary>
        /// Gets or sets the reply to.
        /// </summary>
        [JsonProperty("reply_to")]
        public string ReplyTo { get; set; }

        /// <summary>
        /// Gets or sets the subject line.
        /// </summary>
        [JsonProperty("subject_line")]
        public string SubjectLine { get; set; }

        /// <summary>
        /// Gets or sets the template id.
        /// </summary>
        [JsonProperty("template_id")]
        public int TemplateId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether timewarp.
        /// </summary>
        [JsonProperty("timewarp")]
        public bool Timewarp { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the to name.
        /// </summary>
        [JsonProperty("to_name")]
        public string ToName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether use conversation.
        /// </summary>
        [JsonProperty("use_conversation")]
        public bool UseConversation { get; set; }
    }
}