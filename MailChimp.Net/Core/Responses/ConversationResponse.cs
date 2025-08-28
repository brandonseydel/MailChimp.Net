// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConversationResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The conversation response.
    /// </summary>
    public class ConversationResponse : BaseResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationResponse"/> class.
        /// </summary>
        public ConversationResponse()
        {
            Conversations = new HashSet<Conversation>();
        }

        /// <summary>
        /// Gets or sets the conversations.
        /// </summary>
        [JsonProperty("conversations")]
        public IEnumerable<Conversation> Conversations { get; set; }
    }
}