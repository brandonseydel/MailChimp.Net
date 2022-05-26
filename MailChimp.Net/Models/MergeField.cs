using System.Collections.Generic;

namespace MailChimp.Net.Models
{
	using Newtonsoft.Json;
    using System.Diagnostics;

    public class MergeField : Base, IId<int>
	{

		public MergeField()
		{
			Links = new HashSet<Link>();
			HelpText = string.Empty;
			DefaultValue = string.Empty;
		}

		[JsonProperty("merge_id")]
		public int Id { get; set; }

		[JsonProperty("tag")]
		public string Tag { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("required")]
		public bool Required { get; set; }

		[JsonProperty("default_value")]
		public string DefaultValue { get; set; }

		[JsonProperty("public")]
		public bool Public { get; set; }

		[JsonProperty("display_order")]
		public int DisplayOrder { get; set; }

		[JsonProperty("options")]
		public Options Options { get; set; }

		[JsonProperty("help_text")]
		public string HelpText { get; set; }

		[JsonProperty("list_id")]
		public string ListId { get; set; }

		[JsonProperty("_links")]
		public IEnumerable<Link> Links { get; set; }

        internal override DisplayBuilder GetDebuggerDisplayBuilder(DisplayBuilder Builder) {
            return base.GetDebuggerDisplayBuilder(Builder)
                .Id.Add(Id)
                .Type.Add(Type)
                .Data.Add(Name)
                .Postfix.Add(Tag)
                ;
        }
    }
}
