using System.Collections.Generic;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core;

public class SignupFormResponse : BaseResponse
{
    public SignupFormResponse()
    {
        SignupForms = new HashSet<SignupForm>();
    }

    [MailChimpJsonProperty("signup_forms")]
    public IEnumerable<SignupForm> SignupForms { get; set; }

    [MailChimpJsonProperty("list_id")]
    public string ListId { get; set; }
}
