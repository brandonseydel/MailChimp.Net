using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic
{
    internal class ContentLogic : BaseLogic, IContentLogic
    {
        public ContentLogic(string apiKey) : base(apiKey)
        {
        }

        public async Task<Content> GetAsync(string campaignId)
        {
            using (var client = CreateMailClient("campaigns/"))
            {
                var response = await client.GetAsync($"{campaignId}/contents");
                if (!response.IsSuccessStatusCode)
                {
                    throw (await response.Content.ReadAsStreamAsync()).Deserialize<MailChimpException>();
                }
                return await response.Content.ReadAsAsync<Content>();
            }
        }

        public async Task<Content> AddOrUpdateAsync(string campaignId, ContentRequest content)
        {
            using (var client = CreateMailClient("campaigns/"))
            {
                var response = await client.PutAsJsonAsync($"{campaignId}/contents", content, null);
                if (!response.IsSuccessStatusCode)
                {
                    throw (await response.Content.ReadAsStreamAsync()).Deserialize<MailChimpException>();
                }
                return await response.Content.ReadAsAsync<Content>();
            }
        }
    }
}