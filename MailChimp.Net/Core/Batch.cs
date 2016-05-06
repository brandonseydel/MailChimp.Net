using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
	public class Batch
	{
		/// <summary>
		/// A string that uniquely identifies this batch request.
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// The status of the batch call.
		/// Possible Values:
		/// pending - started - finished
		/// </summary>
		public string Status { get; set; }

		/// <summary>
		/// The total number of operations to complete as part of this batch request. 
		/// For GET requests requiring pagination, each page counts as a separate operation.
		/// </summary>
		[JsonProperty("total_operations")]
		public int TotalOperations { get; set; }

		[System.ComponentModel.Browsable(false), Obsolete("Spelling corrected to FinishedOperations")]
		public string FinishedOperpations { get; set; }

		/// <summary>
		/// The number of completed operations. This includes operations that returned an error.
		/// </summary>
		[JsonProperty("finished_operations")]
		public string FinishedOperations { get; set; }

		/// <summary>
		/// The number of completed operations that returned an error.
		/// </summary>
		[JsonProperty("errored_operations")]
		public string ErroredOperations { get; set; }

		/// <summary>
		/// The time and date when the server received the batch request.
		/// </summary>
		[JsonProperty("submitted_at")]
		public string SubmittedAt { get; set; }

		/// <summary>
		/// The time and date when all operations in the batch request completed.
		/// </summary>
		[JsonProperty("completed_at")]
		public string CompletedAt { get; set; }

		/// <summary>
		/// The URL of the gzipped archive of the results of all the operations.
		/// </summary>
		[JsonProperty("response_body_url")]
		public string ResponseBodyUrl { get; set; }
	}
}
