using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
	public class BatchRequest
	{
		[JsonProperty("operations")]
		public IEnumerable<Operation> Operations { get; set; }
	}
}
