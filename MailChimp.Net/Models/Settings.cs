// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Settings.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The setting.
/// </summary>
public class Setting
{
    /// <summary>
    /// Gets or sets a value indicating whether authenticate.
    /// </summary>
    [MailChimpJsonProperty("authenticate")]
    public bool Authenticate { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether auto footer.
    /// </summary>
    [MailChimpJsonProperty("auto_footer")]
    public bool AutoFooter { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether auto tweet.
    /// </summary>
    [MailChimpJsonProperty("auto_tweet")]
    public bool AutoTweet { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether drag and drop.
    /// </summary>
    [MailChimpJsonProperty("drag_and_drop")]
    public bool DragAndDrop { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether fb comments.
    /// </summary>
    [MailChimpJsonProperty("fb_comments")]
    public bool FbComments { get; set; }

    /// <summary>
    /// Gets or sets the folder id.
    /// </summary>
    [MailChimpJsonProperty("folder_id")]
    public string FolderId { get; set; }

    /// <summary>
    /// Gets or sets the from name.
    /// </summary>
    [MailChimpJsonProperty("from_name")]
    public string FromName { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether inline css.
    /// </summary>
    [MailChimpJsonProperty("inline_css")]
    public bool InlineCss { get; set; }

    /// <summary>
    /// Gets or sets the reply to.
    /// </summary>
    [MailChimpJsonProperty("reply_to")]
    public string ReplyTo { get; set; }

    /// <summary>
    /// Gets or sets the preview text.
    /// </summary>
    [MailChimpJsonProperty("preview_text")]
    public string PreviewText { get; set; }

    /// <summary>
    /// Gets or sets the subject line.
    /// </summary>
    [MailChimpJsonProperty("subject_line")]
    public string SubjectLine { get; set; }

    /// <summary>
    /// Gets or sets the template id.
    /// </summary>
    [MailChimpJsonProperty("template_id")]
    public int TemplateId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether timewarp.
    /// </summary>
    [MailChimpJsonProperty("timewarp")]
    public bool Timewarp { get; set; }

    /// <summary>
    /// Gets or sets the title.
    /// </summary>
    [MailChimpJsonProperty("title")]
    public string Title { get; set; }

    /// <summary>
    /// Gets or sets the to name.
    /// </summary>
    [MailChimpJsonProperty("to_name")]
    public string ToName { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether use conversation.
    /// </summary>
    [MailChimpJsonProperty("use_conversation")]
    public bool UseConversation { get; set; }
}