// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CampaignFolderLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using static System.Net.Http.HttpContentExtensions;
using System.Threading.Tasks;

using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;

namespace MailChimp.Net.Logic
{
    using System.Collections.Generic;

    using MailChimp.Net.Models;

    /// <summary>
    /// The campaign folder logic.
    /// </summary>
    internal class CampaignFolderLogic : BaseLogic, ICampaignFolderLogic
    {

        private const string BaseUrl = "campaign-folders";

        public CampaignFolderLogic(string apiKey)
            : base(apiKey)
        {
            _limit = MailChimpConfiguration.DefaultLimit;
        }

        public CampaignFolderLogic(string apiKey, int limit) : base(apiKey, limit)
        {
        }

        public async Task<Folder> AddAsync(string name)
        {
            using (var client = this.CreateMailClient(BaseUrl))
            {
                var response = await client.PostAsJsonAsync(string.Empty, new {name}).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var foldeResponse = await response.Content.ReadAsAsync<Folder>().ConfigureAwait(false);
                return foldeResponse;
            }
        }


        public async Task<IEnumerable<Folder>> GetAllAsync(QueryableBaseRequest request = null)
        {
            return (await this.GetResponseAsync(request).ConfigureAwait(false))?.Folders;
        }

        public async Task<CampaignFolderResponse> GetResponseAsync(QueryableBaseRequest request = null)
        {
            request = new QueryableBaseRequest
            {
                Limit = base._limit
            };

            using (var client = this.CreateMailClient(BaseUrl))
            {
                var response = await client.GetAsync(request?.ToQueryString()).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var campaignFolderResponse = await response.Content.ReadAsAsync<CampaignFolderResponse>().ConfigureAwait(false);
                return campaignFolderResponse;
            }
        }



        public async Task<Folder> GetAsync(string folderId, BaseRequest request = null)
        {
            using (var client = this.CreateMailClient($"{BaseUrl}/"))
            {
                var response = await client.GetAsync(folderId).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var folder = await response.Content.ReadAsAsync<Folder>().ConfigureAwait(false);
                return folder;
            }
        }



        public async Task DeleteAsync(string folderId)
        {
            using (var client = this.CreateMailClient($"{BaseUrl}/"))
            {
                var response = await client.DeleteAsync($"{folderId}").ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);
            }
        }

        public async Task<Folder> UpdateAsync(string folderId, string name)
        {
            using (var client = this.CreateMailClient($"{BaseUrl}/"))
            {
                var response = await client.PatchAsJsonAsync($"{folderId}", new {name}).ConfigureAwait(false);
                await response.EnsureSuccessMailChimpAsync().ConfigureAwait(false);

                var folder = await response.Content.ReadAsAsync<Folder>().ConfigureAwait(false);
                return folder;

            }
        }



    }
}