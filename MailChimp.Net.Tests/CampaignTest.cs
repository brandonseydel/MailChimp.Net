// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConversationTest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Linq;
using System.Threading.Tasks;

using MailChimp.Net.Core;
using MailChimp.Net.Models;
using Xunit;

namespace MailChimp.Net.Tests
{
    /// <summary>
    /// The campaign test.
    /// </summary>
    public class CampaignTest : MailChimpTest
    {
        /// <summary>
        /// The should_ create_ campaign_
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task Should_Add_Campaign()
        {
            var campaign = await this.MailChimpManager.Campaigns.AddAsync(new Campaign
            {
                Settings = new Setting
                {
                    ReplyTo = "test@test.com",
                    Title = "Get Rich or Die Trying To Add Campaigns",
                    FromName = "AddCampaign",
                    SubjectLine = "TestingAddCampaign"
                },
                Type = CampaignType.Plaintext
            }).ConfigureAwait(false);

            Assert.NotNull(campaign);
        }
        
        /// <summary>
        /// The should_ update_ campaign_
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task Should_Update_Campaign()
        {
            var campaigns = await this.MailChimpManager.Campaigns.GetAll(new CampaignRequest { Limit = 1 }).ConfigureAwait(false);
            var campaign = campaigns.FirstOrDefault();
            if (campaign != null)
            {
                var updated = await this.MailChimpManager.Campaigns.UpdateAsync(campaign.Id, new Campaign
                {
                    Settings = new Setting
                    {
                        ReplyTo = "updatedtest@updatedtest.com",
                        Title = "Updated from Unit Test",
                        FromName = "Updated Tester",
                        SubjectLine = "Updated Test"
                    },
                    Type = CampaignType.Plaintext
                }).ConfigureAwait(false);
                Assert.NotNull(updated);
            }
        }
        
        /// <summary>
        /// The should_ replicate_ campaign_
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task Should_Replicate_Campaign()
        {
            var campaigns = await this.MailChimpManager.Campaigns.GetAllAsync().ConfigureAwait(false);
            var campaign = campaigns.FirstOrDefault();
            if (campaign != null)
            {
                var response = await this.MailChimpManager.Campaigns.ReplicateCampaignAsync(campaign.Id).ConfigureAwait(false);
                Assert.NotNull(response);
            }
        }

        /// <summary>
        /// The should_ delete_ campaign_
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task Should_Delete_Campaign()
        {
            var campaigns = (await this.MailChimpManager.Campaigns.GetAllAsync().ConfigureAwait(false)).ToList();
            var campaign = campaigns.FirstOrDefault();
            if (campaign != null)
            {
                await this.MailChimpManager.Campaigns.DeleteAsync(campaign.Id).ConfigureAwait(false);
                var campaignsnow = await this.MailChimpManager.Campaigns.GetAllAsync();
                Assert.NotEqual(campaigns.Count(), campaignsnow.Count());
            }
        }

        /// <summary>
        /// The should_ get_ one_ campaign_ id_ and_ get_ campaign.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task Should_Get_One_Campain_Id_And_Get_Campaign()
        {
            await this.ClearMailChimpAsync().ConfigureAwait(true);

            await this.MailChimpManager.Campaigns.AddAsync(new Campaign
            {
                Settings = new Setting
                {
                    ReplyTo = "test@test.com",
                    Title = "Get Rich or Die Trying",
                    FromName = "TESTER",
                    SubjectLine = "TEST"
                },
                Type = CampaignType.Plaintext
            }).ConfigureAwait(false);

            await this.MailChimpManager.Campaigns.AddAsync(new Campaign
            {
                Settings = new Setting
                {
                    ReplyTo = "test@test.com",
                    Title = "Get Rich or Die Trying part 2",
                    FromName = "TESTER",
                    SubjectLine = "TEST"
                },
                Type = CampaignType.Plaintext
            }).ConfigureAwait(false);
            
            var campaigns = await this.MailChimpManager.Campaigns.GetAll(new CampaignRequest { Limit = 1 });
            Assert.True(campaigns.Count() == 1);

            var campaign = await this.MailChimpManager.Campaigns.GetAsync(campaigns.FirstOrDefault().Id);

            Assert.NotNull(campaign);
        }

        /// <summary>
        /// The should_ return_ campaigns.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task Should_Return_Campaigns()
        {
            var campaigns = await this.MailChimpManager.Campaigns.GetAll();
            Assert.NotNull(campaigns);
        }

        /// <summary>
        /// The should_ return_ one_ campaign.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task Should_Return_One_Campaign()
        {
            var campaign = await this.MailChimpManager.Campaigns.AddAsync(new Campaign
            {
                Settings = new Setting
                {
                    ReplyTo = "test@test.com",
                    Title = "Get Rich or Die Trying To Add Campaigns",
                    FromName = "AddCampaign",
                    SubjectLine = "TestingAddCampaign"
                },
                Type = CampaignType.Plaintext
            }).ConfigureAwait(false);
            var campaigns = await this.MailChimpManager.Campaigns.GetAll(new CampaignRequest { Limit = 1 });
            Assert.True(campaigns.Count() == 1);
        }

        /// <summary>
        /// Should_Return_Zero_Campaigns_After_Removal.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task Should_Return_No_Campaigns_After_Removal()
        {
            await this.ClearMailChimpAsync().ConfigureAwait(true);

            var campaign = await this.MailChimpManager.Campaigns.AddAsync(new Campaign
            {
                Settings = new Setting
                {
                    ReplyTo = "test@test.com",
                    Title = "Test Campaign",
                    FromName = "TESTER",
                    SubjectLine = "TEST"
                },
                Type = CampaignType.Plaintext
            }).ConfigureAwait(false);

            await this.MailChimpManager.Campaigns.DeleteAsync(campaign.Id).ConfigureAwait(false);
            var existingCampaigns = await this.MailChimpManager.Campaigns.GetAllAsync().ConfigureAwait(false);

            Assert.Equal(0, existingCampaigns.Count());
        }
    }
}