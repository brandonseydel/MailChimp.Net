using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Logic
{
    internal class TemplateFolderLogic : BaseLogic
    {
        public TemplateFolderLogic(string apiKey) : base(apiKey)
        {
        }

        public async Task<IEnumerable<Folder>> GetAllAsync(QueryableBaseRequest request)
        {
            using (var client = CreateMailClient("template-folders"))
            {
                var response = await client.GetAsync(request?.ToQueryString());
                await response.EnsureSuccessMailChimpAsync();

                var templateResponse = await response.Content.ReadAsAsync<TemplateFolderResponse>();
                return templateResponse.Folders;
            }
        }

        public async Task<Folder> AddAsync(string folderId, string name)
        {
            using (var client = CreateMailClient("templates-folders/"))
            {
                var response = await client.PostAsJsonAsync($"{folderId}", new {name});
                await response.EnsureSuccessMailChimpAsync();

                return await response.Content.ReadAsAsync<Folder>();
            }
        }

        public async Task<Folder> UpdateAsync(string folderId, string name)
        {
            using (var client = CreateMailClient("templates-folders/"))
            {
                var response = await client.PatchAsJsonAsync($"{folderId}", new {name});
                await response.EnsureSuccessMailChimpAsync();

                return await response.Content.ReadAsAsync<Folder>();
            }
        }

        public async Task<Folder> DeleteAsync(string folderId)
        {
            using (var client = CreateMailClient("templates-folders/"))
            {
                var response = await client.DeleteAsync($"{folderId}");
                await response.EnsureSuccessMailChimpAsync();

                return await response.Content.ReadAsAsync<Folder>();
            }
        }

        public async Task<Folder> GetAsync(string folderId, BaseRequest request)
        {
            using (var client = CreateMailClient("templates-folders/"))
            {
                var response = await client.GetAsync($"{folderId}{request?.ToQueryString()}");
                await response.EnsureSuccessMailChimpAsync();

                return await response.Content.ReadAsAsync<Folder>();
            }
        }
    }
}