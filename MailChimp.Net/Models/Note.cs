// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Note.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
	/// <summary>
	/// The note.
	/// </summary>
	public class Note
	{
		/// <summary>
		/// Gets or sets the body.
		/// </summary>
		[JsonProperty("note")]
		public string Body { get; set; }

		/// <summary>
		/// Gets or sets the created at.
		/// </summary>
		[JsonProperty("created_at")]
		public string CreatedAt { get; set; }

		/// <summary>
		/// Gets or sets the created by.
		/// </summary>
		[JsonProperty("created_by")]
		public string CreatedBy { get; set; }

		/// <summary>
		/// Gets or sets the email id.
		/// </summary>
		[JsonProperty("email_id")]
		public string EmailId { get; set; }

		/// <summary>
		/// Gets or sets the id.
		/// </summary>
		[JsonProperty("id")]
		public int Id { get; set; }

		/// <summary>
		/// Gets or sets the links.
		/// </summary>
		[JsonProperty("_links")]
		public Link[] Links { get; set; }

		/// <summary>
		/// Gets or sets the list id.
		/// </summary>
		[JsonProperty("list_id")]
		public string ListId { get; set; }

		/// <summary>
		/// Gets or sets the updated at.
		/// </summary>
		[JsonProperty("updated_at")]
		public string UpdatedAt { get; set; }
	}

	public class MemberLastNote
	{
		public MemberLastNote()
		{
			Body = string.Empty;
			CreatedAt = string.Empty;
			CreatedBy = string.Empty;
		}

		/// <summary>
		/// Gets or sets the id.
		/// </summary>
		[JsonProperty("note_id")]
		public int Id { get; set; }

		/// <summary>
		/// Gets or sets the body.
		/// </summary>
		[JsonProperty("note")]
		public string Body { get; set; }

		/// <summary>
		/// Gets or sets the created at.
		/// </summary>
		[JsonProperty("created_at")]
		public string CreatedAt { get; set; }

		/// <summary>
		/// Gets or sets the created by.
		/// </summary>
		[JsonProperty("created_by")]
		public string CreatedBy { get; set; }

	}
}