// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CampaignFolderLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Net.Http;
using System.Threading.Tasks;

using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;

namespace MailChimp.Net.Logic
{
    using System.IO;
    using System.Text;

    using MailChimp.Net.Models;

    /// <summary>
    /// The campaign folder logic.
    /// </summary>
    internal class FileManagerFileLogic : BaseLogic, IFileManagerFileLogic
    {

        private const string BaseUrl = "file-manager/files";

        public FileManagerFileLogic(string apiKey)
            : base(apiKey)
        {
        }

        /// <exception cref="ObjectDisposedException">Either the current stream or <paramref name="destination" /> were closed before the <see cref="M:System.IO.Stream.CopyTo(System.IO.Stream)" /> method was called.</exception>
        /// <exception cref="NotSupportedException">The current stream does not support reading.-or-<paramref name="destination" /> does not support writing.</exception>
        private string ConvertToBase64(Stream stream)
        {
            byte[] bytes;
            using (var memoryStream = new MemoryStream())
            {
                stream.CopyTo(memoryStream);
                bytes = memoryStream.ToArray();
            }
            return Convert.ToBase64String(bytes);
        }


        public async Task<FileManagerFile> AddFileAsync(string name, string folderId, string fileName)
        {
            using(var fs = File.OpenRead(fileName))
            using (var client = this.CreateMailClient(BaseUrl))
            {
                
                var response = await client.PostAsJsonAsync(string.Empty, new { name, folder_id = folderId, file_data = this.ConvertToBase64(fs) }).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var fileManagerFile = await response.Content.ReadAsAsync<FileManagerFile>().ConfigureAwait(false);
                return fileManagerFile;
            }
        }

        public async Task<FileManagerFile> AddAsync(string name, string folderId, string base64String)
        {
            using (var client = this.CreateMailClient(BaseUrl))
            {
                var response = await client.PostAsJsonAsync(string.Empty, new { name, folder_id = folderId, file_data = base64String }).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var fileManagerFile = await response.Content.ReadAsAsync<FileManagerFile>().ConfigureAwait(false);
                return fileManagerFile;
            }
        }

        public async Task<FileManagerFile> AddAsync(string name, string folderId, Stream fileStream)
        {
            using (var client = this.CreateMailClient(BaseUrl))
            {
                var response = await client.PostAsJsonAsync(string.Empty, new { name, folder_id = folderId, file_data = this.ConvertToBase64(fileStream) }).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var fileManagerFile = await response.Content.ReadAsAsync<FileManagerFile>().ConfigureAwait(false);
                return fileManagerFile;
            }
        }



        public async Task<FileManagerFileResponse> GetAllAsync(FileManagerFileRequest request = null)
        {
            using (var client = this.CreateMailClient(BaseUrl))
            {
                var response = await client.GetAsync(request?.ToQueryString()).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var fileManagerFileResponse = await response.Content.ReadAsAsync<FileManagerFileResponse>().ConfigureAwait(false);
                return fileManagerFileResponse;
            }
        }

        public async Task<FileManagerFile> GetAsync(string fileId, BaseRequest request = null)
        {
            using (var client = this.CreateMailClient($"{BaseUrl}/"))
            {
                var response = await client.GetAsync($"{fileId}{request.ToQueryString()}").ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var fileManagerFile = await response.Content.ReadAsAsync<FileManagerFile>().ConfigureAwait(false);
                return fileManagerFile;
            }
        }



        public async Task DeleteAsync(string fileId)
        {
            using (var client = this.CreateMailClient($"{BaseUrl}/"))
            {
                var response = await client.DeleteAsync($"{fileId}").ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
            }
        }

        public async Task<FileManagerFile> UpdateFileAsync(string fileId, string name, string folderId, string fileName)
        {
            using (var fs = File.OpenRead(fileName))
            using (var client = this.CreateMailClient($"{BaseUrl}/"))
            {
                var response = await client.PatchAsJsonAsync($"{fileId}", new { name, folder_id = folderId, file_data = this.ConvertToBase64(fs)}).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var folder = await response.Content.ReadAsAsync<FileManagerFile>().ConfigureAwait(false);
                return folder;

            }
        }


        public async Task<FileManagerFile> UpdateAsync(string fileId, string name, string folderId, string base64String)
        {
            using (var client = this.CreateMailClient($"{BaseUrl}/"))
            {
                var response = await client.PatchAsJsonAsync($"{fileId}", new { name, folder_id = folderId, file_data = base64String}).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var folder = await response.Content.ReadAsAsync<FileManagerFile>().ConfigureAwait(false);
                return folder;

            }
        }

        public async Task<FileManagerFile> UpdateAsync(string fileId, string name, string folderId, Stream stream)
        {
            using (var client = this.CreateMailClient($"{BaseUrl}/"))
            {
                var response = await client.PatchAsJsonAsync($"{fileId}", new { name, folder_id = folderId, file_data = this.ConvertToBase64(stream) }).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var folder = await response.Content.ReadAsAsync<FileManagerFile>().ConfigureAwait(false);
                return folder;

            }
        }





    }
}