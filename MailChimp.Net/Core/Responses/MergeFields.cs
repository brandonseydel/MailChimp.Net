namespace MailChimp.Net.Core.Responses;

public class MergeFields
{
    [MailChimpJsonProperty("FNAME")]
    public string FirstName { get; set; }

    [MailChimpJsonProperty("LNAME")]
    public string LastName { get; set; }

    [MailChimpJsonProperty("ADDRESS")]
    public AddressResponse Address { get; set; }

    [MailChimpJsonProperty("PHONE")]
    public string Phone { get; set; }
}