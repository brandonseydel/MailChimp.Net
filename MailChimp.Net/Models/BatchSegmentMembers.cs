using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class BatchSegmentMembers
    {
        public BatchSegmentMembers()
        {
            MembersToAdd = new string[0];
            MembersToRemove = new string[0];
        }

        /// <summary>
        /// Members to add
        /// </summary>
        [JsonProperty("members_to_add")]
        public string[] MembersToAdd { get; set; }

        /// <summary>
        /// Members to remove
        /// </summary>
        [JsonProperty("members_to_remove")]
        public string[] MembersToRemove { get; set; }
    }
}
