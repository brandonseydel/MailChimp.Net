using System.Collections.Generic;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class SignupForm
{
    public SignupForm()
    {
        Links = new HashSet<Link>();
        Header = new SignupFormHeader();
        Contents = new List<SignupFormContent>();
        Styles = new List<SignupFormStyle>();
    }

    [MailChimpJsonProperty("header")]
    public SignupFormHeader Header { get; set; }

    [MailChimpJsonProperty("contents")]
    public IList<SignupFormContent> Contents { get; set; }

    [MailChimpJsonProperty("styles")]
    public IList<SignupFormStyle> Styles { get; set; }

    [MailChimpJsonProperty("signup_form_url")]
    public string SignupFormUrl { get; set; }

    [MailChimpJsonProperty("list_id")]
    public string ListId { get; set; }

    [MailChimpJsonProperty("_links")]
    public IEnumerable<Link> Links { get; set; }
}

public class SignupFormHeader
{
    [MailChimpJsonProperty("image_url")]
    public string ImageUrl { get; set; }

    [MailChimpJsonProperty("text")]
    public string Text { get; set; }

    [MailChimpJsonProperty("image_width")]
    public string ImageWidth { get; set; }

    [MailChimpJsonProperty("image_height")]
    public string ImageHeight { get; set; }

    [MailChimpJsonProperty("image_alt")]
    public string ImageAlt { get; set; }

    [MailChimpJsonProperty("image_link")]
    public string ImageLink { get; set; }

    [MailChimpJsonProperty("image_align")]
    public string ImageAlign { get; set; }

    [MailChimpJsonProperty("image_border_width")]
    public string ImageBorderWidth { get; set; }

    [MailChimpJsonProperty("image_border_style")]
    public string ImageBorderStyle { get; set; }

    [MailChimpJsonProperty("image_border_color")]
    public string ImageBorderColor { get; set; }

    [MailChimpJsonProperty("image_target")]
    public string ImageTarget { get; set; }
}

public class SignupFormContent
{
    [MailChimpJsonProperty("section")]
    public string Section { get; set; }

    [MailChimpJsonProperty("value")]
    public string Value { get; set; }
}

public class SignupFormStyle
{
    [MailChimpJsonProperty("selector")]
    public string Selector { get; set; }

    [MailChimpJsonProperty("options")]
    public IDictionary<string, string> Options { get; set; }
}
