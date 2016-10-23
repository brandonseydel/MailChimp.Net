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
        /// The should_ get_ one_ campain_ id_ and_ get_ campaign.
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

        /// <summary>
        /// Should_Return_Zero_Campaigns_After_Removal.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public async Task Should_Return_No_Campaigns_After_Removal()
        {
            await this.ClearMailChimpAsync().ConfigureAwait(true);

            var campaign = await this._mailChimpManager.Campaigns.AddAsync(new Campaign
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

            await this._mailChimpManager.Campaigns.DeleteAsync(campaign.Id);
            var existingCampaigns = await this._mailChimpManager.Campaigns.GetAllAsync();

            Assert.AreEqual(0, existingCampaigns.Count());
        }
    }
}