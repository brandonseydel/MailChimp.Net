using System.Collections.Generic;
namespace MailChimp.Net.Core;

	public class BatchRequest
	{
		[MailChimpJsonProperty("operations")]
		public IEnumerable<Operation> Operations { get; set; }
	}
