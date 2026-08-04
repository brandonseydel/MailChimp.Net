// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Note.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;

using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

	/// <summary>
	/// The note.
	/// </summary>
	public class Note
	{
		/// <summary>
		/// Gets or sets the body.
		/// </summary>
		[MailChimpJsonProperty("note")]
		public string Body { get; set; }

		/// <summary>
		/// Gets or sets the created at.
		/// </summary>
		[MailChimpJsonProperty("created_at")]
		public DateTime? CreatedAt { get; set; }

		/// <summary>
		/// Gets or sets the created by.
		/// </summary>
		[MailChimpJsonProperty("created_by")]
		public string CreatedBy { get; set; }

		/// <summary>
		/// Gets or sets the email id.
		/// </summary>
		[MailChimpJsonProperty("email_id")]
		public string EmailId { get; set; }

		/// <summary>
		/// Gets or sets the id.
		/// </summary>
		[MailChimpJsonProperty("id")]
		public int Id { get; set; }

		/// <summary>
		/// Gets or sets the links.
		/// </summary>
		[MailChimpJsonProperty("_links")]
		public Link[] Links { get; set; }

		/// <summary>
		/// Gets or sets the list id.
		/// </summary>
		[MailChimpJsonProperty("list_id")]
		public string ListId { get; set; }

		/// <summary>
		/// Gets or sets the updated at.
		/// </summary>
		[MailChimpJsonProperty("updated_at")]
		public DateTime? UpdatedAt { get; set; }
	}

	public class MemberLastNote
	{
		public MemberLastNote()
		{
			Body = string.Empty;
        CreatedAt = null;
			CreatedBy = string.Empty;
		}

		/// <summary>
		/// Gets or sets the id.
		/// </summary>
		[MailChimpJsonProperty("note_id")]
		public int Id { get; set; }

		/// <summary>
		/// Gets or sets the body.
		/// </summary>
		[MailChimpJsonProperty("note")]
		public string Body { get; set; }

		/// <summary>
		/// Gets or sets the created at.
		/// </summary>
		[MailChimpJsonProperty("created_at")]
		public DateTime? CreatedAt { get; set; }

		/// <summary>
		/// Gets or sets the created by.
		/// </summary>
		[MailChimpJsonProperty("created_by")]
		public string CreatedBy { get; set; }

	}