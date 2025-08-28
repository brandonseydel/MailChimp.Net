using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// Content options for Multivariate Campaigns. Each content option must provide HTML content and may optionally provide plain text. For campaigns not testing content, only one object should be provided.
    /// </summary>
    public class VariateContents
    {
        /// <summary>
        /// The label used to identify the content option.
        /// </summary>
        [JsonProperty("content_label", Required = Required.Always)]
        public string ContentLabel { get; set; }

        /// <summary>
        /// The plain-text portion of the campaign. If left unspecified, we�ll generate this automatically.
        /// </summary>
        [JsonProperty("plain_text")]
        public string PlainText { get; set; }

        /// <summary>
        /// The raw HTML for the campaign.
        /// </summary>
        [JsonProperty("html")]
        public string Html { get; set; }

        /// <summary>
        /// Use this template to generate the HTML content for the campaign.
        /// </summary>
        public Template Template { get; set; }

        /// <summary>
        /// Available when uploading an archive to create campaign content. The archive should include all campaign content and images. Learn more.
        /// </summary>
        public Archive Archive { get; set; }

        /// <summary>
        /// When importing a campaign, the URL for the HTML.
        /// </summary>
        public string Url { get; set; }
    }
}