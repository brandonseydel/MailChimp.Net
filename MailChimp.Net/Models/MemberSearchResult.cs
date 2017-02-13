using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Net.Models
{

    public class MemberSearchResult
    {
        public MemberSearchResult()
        {
            this.Links = new HashSet<Link>();
        }

        [JsonProperty("exact_matches")]
        public ExactMatch ExactMatch { get; set; }

        [JsonProperty("full_search")]
        public FullSearch FullSearch { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }
    }

}
