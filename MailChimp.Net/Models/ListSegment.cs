using System;
using System.Collections.Generic;
using System.Diagnostics;
using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class ListSegment : Base, IId<int>
    {
        public ListSegment()
        {
            Links = new HashSet<Link>();
        }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("member_count")]
        public int MemberCount { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("list_id")]
        public string ListId { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }

        [JsonProperty("options")]
        public SegmentOptions Options { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Id.Add(Id)
                .Type.Add(Type)
                .Data.Add(Name)
                ;
        }
    }
}
