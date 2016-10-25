// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConversationTest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Linq;
using System.Threading.Tasks;

using MailChimp.Net.Core;
using MailChimp.Net.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailChimp.Net.Tests
{
    /// <summary>
    /// The campaign test.
    /// </summary>
    [TestClass]
    public class CampaignTest : MailChimpTest
    {
        /// <summary>
        /// The should_ create_ campaign_
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task Should_Add_Campaign()
        {
            var campaign = await this._mailChimpManager.Campaigns.AddAsync(new Campaign
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

            Assert.IsNotNull(campaign);
        }
        
        /// <summary>
        /// The should_ update_ campaign_
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task Should_Update_Campaign()
        {
            var campaigns = await this._mailChimpManager.Campaigns.GetAll(new CampaignRequest { Limit = 1 });
            var campaign = campaigns.FirstOrDefault();
            if (campaign != null)
            {
                var updated = await this._mailChimpManager.Campaigns.UpdateAsync(campaign.Id, new Campaign
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
                Assert.IsNotNull(updated);
            }
        }
        
        /// <summary>
        /// The should_ replicate_ campaign_
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task Should_Replicate_Campaign()
        {
            var campaigns = await this._mailChimpManager.Campaigns.GetAllAsync();
            var campaign = campaigns.FirstOrDefault();
            if (campaign != null)
            {
                var response = await this._mailChimpManager.Campaigns.ReplicateCampaignAsync(campaign.Id).ConfigureAwait(false);
                Assert.IsNotNull(response);
            }
        }

        /// <summary>
        /// The should_ delete_ campaign_
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task Should_Delete_Campaign()
        {
            var campaigns = await this._mailChimpManager.Campaigns.GetAllAsync();
            var campaign = campaigns.FirstOrDefault();
            if (campaign != null)
            {
                await this._mailChimpManager.Campaigns.DeleteAsync(campaign.Id).ConfigureAwait(false);
                var campaignsnow = await this._mailChimpManager.Campaigns.GetAllAsync();
                Assert.AreNotEqual(campaigns.Count(), campaignsnow.Count());
            }
        }

        /// <summary>
        /// The should_ get_ one_ campaign_ id_ and_ get_ campaign.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public async Task Should_Get_One_Campain_Id_And_Get_Campaign()
        {
            await this.ClearMailChimpAsync().ConfigureAwait(true);

            await this._mailChimpManager.Campaigns.AddAsync(new Campaign
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

            await this._mailChimpManager.Campaigns.AddAsync(new Campaign
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



            var campaigns = await this._mailChimpManager.Campaigns.GetAll(new CampaignRequest { Limit = 1 });
            Assert.IsTrue(campaigns.Count() == 1);

            var campaign = await this._mailChimpManager.Campaigns.GetAsync(campaigns.FirstOrDefault().Id);

            Assert.IsNotNull(campaign);
        }

        /// <summary>
        /// The should_ return_ campaigns.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public async Task Should_Return_Campaigns()
        {
            var campaigns = await this._mailChimpManager.Campaigns.GetAll();
            Assert.IsNotNull(campaigns);
        }

        /// <summary>
        /// The should_ return_ one_ campaign.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public async Task Should_Return_One_Campaign()
        {
            var campaigns = await this._mailChimpManager.Campaigns.GetAll(new CampaignRequest { Limit = 1 });
            Assert.IsTrue(campaigns.Count() == 1);
        }
    }
}