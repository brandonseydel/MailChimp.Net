using System;
using System.Collections.Generic;
using System.Text;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class VariateSettings
{
    [MailChimpJsonProperty("winning_combination_id")]
    public string WinningCombinationId { get; set; }

    [MailChimpJsonProperty("winning_campaign_id")]
    public string WinningCampaignId { get; set; }
    [MailChimpJsonProperty("winner_criteria")]
    public string WinnerCriteria { get; set; }
    [MailChimpJsonProperty("combinations")]
    public IEnumerable<Combination> Combinations { get; set; }
}
