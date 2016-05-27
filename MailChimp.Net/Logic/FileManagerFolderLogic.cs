// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileManagerFolderLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using static System.Net.Http.HttpContentExtensions;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;


namespace MailChimp.Net.Logic
{
    /// <summary>
    ///     The file manager folder logic.
    /// </summary>
    internal class FileManagerFolderLogic : BaseLogic, IFileManagerFolderLogic
    {
        private const string BaseUrl = "file-manager/folders";

        public FileManagerFolderLogic(string apiKey)
            : base(apiKey)
        {
        }

        public async Task<FileManagerFolder> AddAsync(string name)
        {
            using (var client = CreateMailClient(BaseUrl))
            {
                var response = await client.PostAsJsonAsync(string.Empty, new {name}).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var fileManagerFolder = await response.Content.ReadAsAsync<FileManagerFolder>().ConfigureAwait(false);
                return fileManagerFolder;
            }
        }


        public async Task<IEnumerable<FileManagerFolder>> GetAllAsync(FileManagerRequest request = null)
        {
            using (var client = CreateMailClient(BaseUrl))
            {
                var response = await client.GetAsync(request?.ToQueryString()).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var fileManagerFolderResponse =
                    await response.Content.ReadAsAsync<FileManagerFolderResponse>().ConfigureAwait(false);
                return fileManagerFolderResponse.Folders;
            }
        }

        public async Task<FileManagerFolderResponse> GetResponseAsync(FileManagerRequest request = null)
        {
            using (var client = CreateMailClient(BaseUrl))
            {
                var response = await client.GetAsync(request?.ToQueryString()).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var fileManagerFolderResponse =
                    await response.Content.ReadAsAsync<FileManagerFolderResponse>().ConfigureAwait(false);
                return fileManagerFolderResponse;
            }
        }


        public async Task<FileManagerFolder> GetAsync(string folderId, BaseRequest request = null)
        {
            using (var client = CreateMailClient($"{BaseUrl}/"))
            {
                var response = await client.GetAsync($"{folderId}{request?.ToQueryString()}").ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var fileManagerFolder = await response.Content.ReadAsAsync<FileManagerFolder>().ConfigureAwait(false);
                return fileManagerFolder;
            }
        }


        public async Task DeleteAsync(string folderId)
        {
            using (var client = CreateMailClient($"{BaseUrl}/"))
            {
                var response = await client.DeleteAsync($"{folderId}").ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
            }
        }


        public async Task<FileManagerFolder> UpdateAsync(string name, string folderId)
        {
            using (var client = CreateMailClient($"{BaseUrl}/"))
            {
                var response = await client.PatchAsJsonAsync($"{folderId}", new {name}).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
                var folder = await response.Content.ReadAsAsync<FileManagerFolder>().ConfigureAwait(false);
                return folder;
            }
        }
    }
}