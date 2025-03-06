// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CampaignFolderLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;

namespace MailChimp.Net.Logic
{
    using System.Collections.Generic;
    using System.Threading;
    using Models;

    /// <summary>
    /// The campaign folder logic.
    /// </summary>
    internal class CampaignFolderLogic : BaseLogic, ICampaignFolderLogic
    {

        private const string BaseUrl = "campaign-folders";

        public CampaignFolderLogic(MailChimpOptions mailChimpConfiguration)
            : base(mailChimpConfiguration)
        {
        }

        public async Task<Folder> AddAsync(string name, CancellationToken cancellationToken = default)
        {
            using var client = CreateMailClient(BaseUrl);
            var response = await client.PostAsJsonAsync(string.Empty, new { name }, cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

            var foldeResponse = await response.Content.ReadAsAsync<Folder>().ConfigureAwait(false);
            return foldeResponse;
        }


        public async Task<IEnumerable<Folder>> GetAllAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default) 
            => (await GetResponseAsync(request, cancellationToken).ConfigureAwait(false))?.Folders;

        public async Task<CampaignFolderResponse> GetResponseAsync(QueryableBaseRequest request = null, CancellationToken cancellationToken = default)
        {
            request ??= new QueryableBaseRequest
            {
                Limit = _limit
            };

            using var client = CreateMailClient(BaseUrl);
            var response = await client.GetAsync(request.ToQueryString(), cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

            var campaignFolderResponse = await response.Content.ReadAsAsync<CampaignFolderResponse>().ConfigureAwait(false);
            return campaignFolderResponse;
        }



        public async Task<Folder> GetAsync(string folderId, BaseRequest request = null, CancellationToken cancellationToken = default)
        {
            using var client = CreateMailClient($"{BaseUrl}/");
            var response = await client.GetAsync(folderId, cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

            var folder = await response.Content.ReadAsAsync<Folder>().ConfigureAwait(false);
            return folder;
        }



        public async Task DeleteAsync(string folderId, CancellationToken cancellationToken = default)
        {
            using var client = CreateMailClient($"{BaseUrl}/");
            var response = await client.DeleteAsync($"{folderId}", cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
        }

        public async Task<Folder> UpdateAsync(string folderId, string name, CancellationToken cancellationToken = default)
        {
            using var client = CreateMailClient($"{BaseUrl}/");
            var response = await client.PatchAsJsonAsync($"{folderId}", new { name }, cancellationToken).ConfigureAwait(false);
            await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

            var folder = await response.Content.ReadAsAsync<Folder>().ConfigureAwait(false);
            return folder;
        }



    }
}