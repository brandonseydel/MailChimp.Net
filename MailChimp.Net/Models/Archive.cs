using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Archive
    {
        [JsonProperty("archive_content")]
        public string ArchiveContent { get; set; }
        [JsonProperty("arhive_type")]
        public string ArchiveType { get; set; }
    }
}