using System.Collections.Generic;
using MailChimp.Net.Models;
namespace MailChimp.Net.Core;

public class SurveyResponse : BaseResponse
{
    public SurveyResponse()
    {
        Surveys = new HashSet<Survey>();
    }

    [MailChimpJsonProperty("surveys")]
    public IEnumerable<Survey> Surveys { get; set; }

    [MailChimpJsonProperty("list_id")]
    public string ListId { get; set; }
}
