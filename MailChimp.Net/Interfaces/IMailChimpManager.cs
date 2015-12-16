using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Models;
using MailChimp.Net.Requests;

namespace MailChimp.Net.Interfaces
{
    public interface IMailChimpManager
    {
        IListLogic Lists { get; }
        IMemberLogic Members { get; }
        IApiLogic Api { get; }
        ICampaignLogic Campaigns { get; }
    }
}