namespace MailChimp.Net.Core;

	public class Operation
	{
		public Operation()
		{
			OperationId = string.Empty;
			Params = new object();
		}
		/// <summary>
		/// The HTTP method to use for the operation.
		/// Possible Values:
		/// GET - POST - PUT - PATCH
		/// </summary>
		[MailChimpJsonProperty("method")]
		public string Method { get; set; }
		/// <summary>
		/// The relative path to use for the operation.
		/// </summary>
		[MailChimpJsonProperty("path")]
		public string Path { get; set; }
		/// <summary>
		/// Any URL params to use, only applies to GET operations.
		/// </summary>
		[MailChimpJsonProperty("params")]
		public object Params { get; set; }
		/// <summary>
		/// A string containing the JSON body to use with the request.
		/// </summary>
		[MailChimpJsonProperty("body")]
		public string Body { get; set; }
		/// <summary>
		/// An optional client-supplied id returned with the operation results.
		/// </summary>
		[MailChimpJsonProperty("operation_id")]
		public string OperationId { get; set; }
	}
