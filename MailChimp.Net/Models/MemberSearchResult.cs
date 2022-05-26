using Newtonsoft.Json;
using System.Collections.Generic;

namespace MailChimp.Net.Models
{

    public class MemberSearchResult : Base
    {
        public MemberSearchResult()
        {
            Links = new HashSet<Link>();
        }

        [JsonProperty("exact_matches")]
        public ExactMatch ExactMatch { get; set; }

        [JsonProperty("full_search")]
        public FullSearch FullSearch { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }
    }

}
