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
using System.Threading;
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
        public async Task<FileManagerFile> AddFileAsync(string name, string folderId, string fileName, CancellationToken cancellationToken = default) 
            => await AddFileAsync(name, int.TryParse(folderId, out var result) ? result : 0, fileName, cancellationToken);
        public async Task<FileManagerFile> AddFileAsync(string name, int folderId, string fileName, CancellationToken cancellationToken = default)
        {
            using var fs = File.OpenRead(fileName);
            using var client = CreateMailClient(BaseUrl);

            var response = await client.PostAsJsonAsync(string.Empty, new { name, folder_id = folderId, file_data = ConvertToBase64(fs) }, cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

            var fileManagerFile = await response.Content.ReadAsAsync<FileManagerFile>().ConfigureAwait(false);
            return fileManagerFile;
        }

        [Obsolete("This method is deprecated.")]
        public async Task<FileManagerFile> AddAsync(string name, string folderId, string base64String, CancellationToken cancellationToken = default) 
            => await AddAsync(name, int.TryParse(folderId, out var result) ? result : 0, base64String, cancellationToken);
        public async Task<FileManagerFile> AddAsync(string name, int folderId, string base64String, CancellationToken cancellationToken = default)
        {
            using var client = CreateMailClient(BaseUrl);
            var response = await client.PostAsJsonAsync(string.Empty, new { name, folder_id = folderId, file_data = base64String }, cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

            var fileManagerFile = await response.Content.ReadAsAsync<FileManagerFile>().ConfigureAwait(false);
            return fileManagerFile;
        }

        [Obsolete("This method is deprecated.")]
        public async Task<FileManagerFile> AddAsync(string name, string folderId, Stream fileStream, CancellationToken cancellationToken = default) => await AddAsync(name, int.TryParse(folderId, out var result) ? result : 0, fileStream);
        public async Task<FileManagerFile> AddAsync(string name, int folderId, Stream fileStream, CancellationToken cancellationToken = default)
        {
            using var client = CreateMailClient(BaseUrl);
            var response = await client.PostAsJsonAsync(string.Empty, new { name, folder_id = folderId, file_data = ConvertToBase64(fileStream) }, cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

            var fileManagerFile = await response.Content.ReadAsAsync<FileManagerFile>().ConfigureAwait(false);
            return fileManagerFile;
        }


        public async Task<IEnumerable<FileManagerFile>> GetAllAsync(FileManagerRequest request = null, CancellationToken cancellationToken = default) 
            => (await GetResponseAsync(request, cancellationToken).ConfigureAwait(false))?.Files;

        public async Task<FileManagerFileResponse> GetResponseAsync(FileManagerRequest request = null, CancellationToken cancellationToken = default)
        {
            request ??= new FileManagerRequest
            {
                Limit = _limit
            };

            using var client = CreateMailClient(BaseUrl);
            var response = await client.GetAsync(request.ToQueryString(), cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

            var fileManagerFileResponse = await response.Content.ReadAsAsync<FileManagerFileResponse>().ConfigureAwait(false);
            return fileManagerFileResponse;
        }

        public async Task<FileManagerFile> GetAsync(string fileId, BaseRequest request = null, CancellationToken cancellationToken = default)
        {
            using var client = CreateMailClient($"{BaseUrl}/");
            var response = await client.GetAsync($"{fileId}{request?.ToQueryString()}", cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

            var fileManagerFile = await response.Content.ReadAsAsync<FileManagerFile>().ConfigureAwait(false);
            return fileManagerFile;
        }

        public async Task DeleteAsync(string fileId, CancellationToken cancellationToken = default)
        {
            using var client = CreateMailClient($"{BaseUrl}/");
            var response = await client.DeleteAsync($"{fileId}", cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        }
        [Obsolete("This method is deprecated.")]
        public async Task<FileManagerFile> UpdateFileAsync(string fileId, string name, string folderId, string fileName, CancellationToken cancellationToken = default) 
            => await UpdateFileAsync(fileId, name, int.TryParse(folderId, out var result) ? result : 0, fileName, cancellationToken);
        public async Task<FileManagerFile> UpdateFileAsync(string fileId, string name, int folderId, string fileName, CancellationToken cancellationToken = default)
        {
            using var fs = File.OpenRead(fileName);
            using var client = CreateMailClient($"{BaseUrl}/");
            var response = await client.PatchAsJsonAsync($"{fileId}", new { name, folder_id = folderId, file_data = ConvertToBase64(fs) }, cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

            var folder = await response.Content.ReadAsAsync<FileManagerFile>().ConfigureAwait(false);
            return folder;
        }

        [Obsolete("This method is deprecated.")]
        public async Task<FileManagerFile> UpdateAsync(string fileId, string name, string folderId, string base64String, CancellationToken cancellationToken = default) 
            => await UpdateAsync(fileId, name, int.TryParse(folderId, out var result) ? result : 0, base64String, cancellationToken);
        public async Task<FileManagerFile> UpdateAsync(string fileId, string name, int folderId, string base64String, CancellationToken cancellationToken = default)
        {
            using var client = CreateMailClient($"{BaseUrl}/");
            var response = await client.PatchAsJsonAsync($"{fileId}", new { name, folder_id = folderId, file_data = base64String },cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

            var folder = await response.Content.ReadAsAsync<FileManagerFile>().ConfigureAwait(false);
            return folder;
        }
        [Obsolete("This method is deprecated.")]
        public async Task<FileManagerFile> UpdateAsync(string fileId, string name, string folderId, Stream stream, CancellationToken cancellationToken = default) 
            => await UpdateAsync(fileId, name, int.TryParse(folderId, out var result) ? result : 0, stream, cancellationToken);
        public async Task<FileManagerFile> UpdateAsync(string fileId, string name, int folderId, Stream stream, CancellationToken cancellationToken = default)
        {
            using var client = CreateMailClient($"{BaseUrl}/");
            var response = await client.PatchAsJsonAsync($"{fileId}", new { name, folder_id = folderId, file_data = ConvertToBase64(stream) }, cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

            var folder = await response.Content.ReadAsAsync<FileManagerFile>().ConfigureAwait(false);
            return folder;
        }
    }
}