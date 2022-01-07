using System.Threading.Tasks;

namespace MailChimp.Net.Interfaces
{
    public interface ICustomerJourneysLogic
    {
        Task TriggerAsync(int journeyId, int stepId, string emailAddress);
    }
}