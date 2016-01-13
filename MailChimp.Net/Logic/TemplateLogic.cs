using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic
{
    internal class TemplateLogic : BaseLogic, ITemplateLogic
    {
        public TemplateLogic(string apiKey) : base(apiKey)
        {
        }

        public async Task<IEnumerable<Template>> GetAllAsync(TemplateRequest request)
        {
            using (var client = CreateMailClient("templates"))
            {
                var response = await client.GetAsync(request?.ToQueryString());
                await response.EnsureSuccessMailChimpAsync();

                var templateResponse = await response.Content.ReadAsAsync<TemplateResponse>();
                return templateResponse.Templates;
            }
        }

        public async Task<Template> GetAsync(string templateId)
        {
            using (var client = CreateMailClient("templates/"))
            {
                var response = await client.GetAsync($"{templateId}");
                await response.EnsureSuccessMailChimpAsync();

                return await response.Content.ReadAsAsync<Template>();
            }
        }
        public async Task DeleteAsync(string templateId)
        {
            using (var client = CreateMailClient("templates/"))
            {
                var response = await client.DeleteAsync($"{templateId}");
                await response.EnsureSuccessMailChimpAsync();
            }
        }

       
    }
}