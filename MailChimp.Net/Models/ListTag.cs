using System;
using System.Collections.Generic;
using System.Text;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class ListTag
{
    /// <summary>
    /// Gets or sets the tag's name.
    /// </summary>
    [MailChimpJsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the tag's id).
    /// </summary>
    [MailChimpJsonProperty("id")]
    public string Id { get; set; }

}
