using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
	public class BatchRequest
	{
		[JsonProperty("operations")]
		public IEnumerable<Operation> Operations { get; set; }
	}
}
