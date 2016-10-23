// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FeedbackTest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using MailChimp.Net.Models;
using MailChimp.Net.Core;
using System.Threading.Tasks;
using System.Linq;

namespace MailChimp.Net.Tests
{
    /// <summary>
    /// The feedback test.
    /// </summary>
    [TestClass]
    public class FeedbackTest : MailChimpTest
    {
        /// <summary>
        /// Should_Create_One_Feedback.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public async Task Should_Create_One_Feedback()
        {
            await this.ClearMailChimpAsync().ConfigureAwait(true);

            var campaign = await CreateCampaign();
            
            var createdFeedback = await this._mailChimpManager.Feedback.AddOrUpdateAsync(campaign.Id, new Feedback() {
                Message = "Test feedback"
            });

            var feedback = await this._mailChimpManager.Feedback.GetAsync(campaign.Id, createdFeedback.FeedbackId.Value.ToString());

            Assert.IsNotNull(feedback);
        }

        /// <summary>
        /// Should_Return_Feedback.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public async Task Should_Return_Feedback()
        {
            var campaign = await CreateCampaign();
            var feedbacks = await this._mailChimpManager.Feedback.GetAllAsync(campaign.Id);
            Assert.IsNotNull(feedbacks);
        }

        /// <summary>
        /// Should_Return_Multiple_Feedback.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public async Task Should_Return_Multiple_Feedback()
        {
            await this.ClearMailChimpAsync().ConfigureAwait(true);

            var campaign = await CreateCampaign();

            for (int i = 0; i < 3; i++)
            {
                await this._mailChimpManager.Feedback.AddOrUpdateAsync(campaign.Id, new Feedback()
                {
                    Message = "Test feedback"
                });
            }

            var feedbacks = await this._mailChimpManager.Feedback.GetAllAsync(campaign.Id);
            Assert.IsTrue(feedbacks.Count() == 3);
        }

        /// <summary>
        /// Should_Return_No_Feedback_After_Removal.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public async Task Should_Return_No_Feedback_After_Removal()
        {
            await this.ClearMailChimpAsync().ConfigureAwait(true);

            var campaign = await CreateCampaign();

            var createdFeedback = await this._mailChimpManager.Feedback.AddOrUpdateAsync(campaign.Id, new Feedback()
            {
                Message = "Test feedback"
            });

            await this._mailChimpManager.Feedback.DeleteAsync(campaign.Id, createdFeedback.FeedbackId.Value.ToString());
            var feedback = await this._mailChimpManager.Feedback.GetAllAsync(campaign.Id);

            Assert.AreEqual(0, feedback.Count());
        }

        private async Task<Campaign> CreateCampaign()
        {
            var campaign = await this._mailChimpManager.Campaigns.AddAsync(new Campaign
            {
                Settings = new Setting
                {
                    ReplyTo = "test@test.com",
                    Title = "Test Campaign",
                    FromName = "TESTER",
                    SubjectLine = "TEST"
                },
                Type = CampaignType.Plaintext,

            }).ConfigureAwait(false);
            return campaign;
        }
    }
}