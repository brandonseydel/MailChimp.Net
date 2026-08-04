using System.Collections.Generic;

using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

	public class MergeField
	{

		public MergeField()
		{
			Links = new HashSet<Link>();
			HelpText = string.Empty;
			DefaultValue = string.Empty;
		}

		[MailChimpJsonProperty("merge_id")]
		public int MergeId { get; set; }

		[MailChimpJsonProperty("tag")]
		public string Tag { get; set; }

		[MailChimpJsonProperty("name")]
		public string Name { get; set; }

		[MailChimpJsonProperty("type")]
		public string Type { get; set; }

		[MailChimpJsonProperty("required")]
		public bool Required { get; set; }

		[MailChimpJsonProperty("default_value")]
		public string DefaultValue { get; set; }

		[MailChimpJsonProperty("public")]
		public bool Public { get; set; }

		[MailChimpJsonProperty("display_order")]
		public int DisplayOrder { get; set; }

		[MailChimpJsonProperty("options")]
		public Options Options { get; set; }

		[MailChimpJsonProperty("help_text")]
		public string HelpText { get; set; }

		[MailChimpJsonProperty("list_id")]
		public string ListId { get; set; }

		[MailChimpJsonProperty("_links")]
		public IEnumerable<Link> Links { get; set; }
	}
