using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic
{
    internal class ApiLogic : BaseLogic, IApiLogic
    {
        public ApiLogic(string apiKey) : base(apiKey)
        {
        }

        public async Task<ApiInfo> GetInfo()
        {
            using (var client = CreateMailClient(""))
            {
                var response = await client.GetAsync($"");
                if (!response.IsSuccessStatusCode)
                {
                    throw (await response.Content.ReadAsStreamAsync()).Deserialize<MailChimpException>();
                }

                return await response.Content.ReadAsAsync<ApiInfo>();
            }
        }
    }
}