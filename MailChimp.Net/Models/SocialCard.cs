using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

public class SocialCard
{
    [MailChimpJsonProperty("image_url")]
    public string ImageUrl { get; set; }

    [MailChimpJsonProperty("description")]
    public string Description { get; set; }

    [MailChimpJsonProperty("title")]
    public string Title { get; set; }
}