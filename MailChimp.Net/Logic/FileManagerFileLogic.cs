// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CampaignFolderLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace MailChimp.Net.Logic
{
    /// <summary>
    /// The campaign folder logic.
    /// </summary>
    internal class FileManagerFileLogic : BaseLogic, IFileManagerFileLogic
    {

        private const string BaseUrl = "file-manager/files";

        public FileManagerFileLogic(MailChimpOptions mailChimpConfiguration)
            : base(mailChimpConfiguration)
        {
        }

        /// <exception cref="ObjectDisposedException">Either the current stream or <paramref>
        ///         <name>destination</name>
        ///     </paramref>
        ///     were closed before the <see cref="M:System.IO.Stream.CopyTo(System.IO.Stream)" /> method was called.</exception>
        /// <exception cref="NotSupportedException">The current stream does not support reading.-or-<paramref>
        ///         <name>destination</name>
        ///     </paramref>
        ///     does not support writing.</exception>
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

        [Obsolete("This method is deprecated.")]
        public async Task<FileManagerFile> AddFileAsync(string name, string folderId, string fileName)
        {
            return await AddFileAsync(name, int.TryParse(folderId, out var result) ? result : 0, fileName);
        }
        public async Task<FileManagerFile> AddFileAsync(string name, int folderId, string fileName)
        {
            using (var fs = File.OpenRead(fileName))
            using (var client = CreateMailClient(BaseUrl))
            {

                var response = await client.PostAsJsonAsync(string.Empty, new { name, folder_id = folderId, file_data = ConvertToBase64(fs) }).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var fileManagerFile = await response.Content.ReadAsAsync<FileManagerFile>().ConfigureAwait(false);
                return fileManagerFile;
            }
        }

        [Obsolete("This method is deprecated.")]
        public async Task<FileManagerFile> AddAsync(string name, string folderId, string base64String)
        {
            return await AddAsync(name, int.TryParse(folderId, out var result) ? result : 0, base64String);
        }
        public async Task<FileManagerFile> AddAsync(string name, int folderId, string base64String)
        {
            using (var client = CreateMailClient(BaseUrl))
            {
                var response = await client.PostAsJsonAsync(string.Empty, new { name, folder_id = folderId, file_data = base64String }).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var fileManagerFile = await response.Content.ReadAsAsync<FileManagerFile>().ConfigureAwait(false);
                return fileManagerFile;
            }
        }

        [Obsolete("This method is deprecated.")]
        public async Task<FileManagerFile> AddAsync(string name, string folderId, Stream fileStream)
        {
            return await AddAsync(name, int.TryParse(folderId, out var result) ? result : 0, fileStream);
        }
        public async Task<FileManagerFile> AddAsync(string name, int folderId, Stream fileStream)
        {
            using (var client = CreateMailClient(BaseUrl))
            {
                var response = await client.PostAsJsonAsync(string.Empty, new { name, folder_id = folderId, file_data = ConvertToBase64(fileStream) }).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var fileManagerFile = await response.Content.ReadAsAsync<FileManagerFile>().ConfigureAwait(false);
                return fileManagerFile;
            }
        }


        public async Task<IEnumerable<FileManagerFile>> GetAllAsync(FileManagerRequest request = null)
        {
            return (await GetResponseAsync(request).ConfigureAwait(false))?.Files;
        }

        public async Task<FileManagerFileResponse> GetResponseAsync(FileManagerRequest request = null)
        {
            request = request ?? new FileManagerRequest
            {
                Limit = _limit
            };

            using (var client = CreateMailClient(BaseUrl))
            {
                var response = await client.GetAsync(request.ToQueryString()).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var fileManagerFileResponse = await response.Content.ReadAsAsync<FileManagerFileResponse>().ConfigureAwait(false);
                return fileManagerFileResponse;
            }
        }




        public async Task<FileManagerFile> GetAsync(string fileId, BaseRequest request = null)
        {
            using (var client = CreateMailClient($"{BaseUrl}/"))
            {
                var response = await client.GetAsync($"{fileId}{request?.ToQueryString()}").ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var fileManagerFile = await response.Content.ReadAsAsync<FileManagerFile>().ConfigureAwait(false);
                return fileManagerFile;
            }
        }



        public async Task DeleteAsync(string fileId)
        {
            using (var client = CreateMailClient($"{BaseUrl}/"))
            {
                var response = await client.DeleteAsync($"{fileId}").ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
            }
        }
        [Obsolete("This method is deprecated.")]
        public async Task<FileManagerFile> UpdateFileAsync(string fileId, string name, string folderId, string fileName)
        {
            return await UpdateFileAsync(fileId, name, int.TryParse(folderId, out var result) ? result : 0, fileName);
        }
        public async Task<FileManagerFile> UpdateFileAsync(string fileId, string name, int folderId, string fileName)
        {
            using (var fs = File.OpenRead(fileName))
            using (var client = CreateMailClient($"{BaseUrl}/"))
            {
                var response = await client.PatchAsJsonAsync($"{fileId}", new { name, folder_id = folderId, file_data = ConvertToBase64(fs) }).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var folder = await response.Content.ReadAsAsync<FileManagerFile>().ConfigureAwait(false);
                return folder;

            }
        }

        [Obsolete("This method is deprecated.")]
        public async Task<FileManagerFile> UpdateAsync(string fileId, string name, string folderId, string base64String)
        {
            return await UpdateAsync(fileId, name, int.TryParse(folderId, out var result) ? result : 0, base64String);
        }
        public async Task<FileManagerFile> UpdateAsync(string fileId, string name, int folderId, string base64String)
        {
            using (var client = CreateMailClient($"{BaseUrl}/"))
            {
                var response = await client.PatchAsJsonAsync($"{fileId}", new { name, folder_id = folderId, file_data = base64String }).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var folder = await response.Content.ReadAsAsync<FileManagerFile>().ConfigureAwait(false);
                return folder;

            }
        }
        [Obsolete("This method is deprecated.")]
        public async Task<FileManagerFile> UpdateAsync(string fileId, string name, string folderId, Stream stream)
        {
            return await UpdateAsync(fileId, name, int.TryParse(folderId, out var result) ? result : 0, stream);
        }
        public async Task<FileManagerFile> UpdateAsync(string fileId, string name, int folderId, Stream stream)
        {
            using (var client = CreateMailClient($"{BaseUrl}/"))
            {
                var response = await client.PatchAsJsonAsync($"{fileId}", new { name, folder_id = folderId, file_data = ConvertToBase64(stream) }).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var folder = await response.Content.ReadAsAsync<FileManagerFile>().ConfigureAwait(false);
                return folder;

            }
        }
    }
}