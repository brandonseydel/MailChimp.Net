using System.Threading.Tasks;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface IApiLogic
    {
        Task<ApiInfo> GetInfo();
    }
}