// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FeedbackTest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Xunit;
using MailChimp.Net.Models;
using MailChimp.Net.Core;
using System.Threading.Tasks;
using System.Linq;

namespace MailChimp.Net.Tests
{
    /// <summary>
    /// The feedback test.
    /// </summary>
    public class FeedbackTest : MailChimpTest
    {
        /// <summary>
        /// Should_Create_One_Feedback.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task Should_Create_One_Feedback()
        {
            await this.ClearMailChimpAsync().ConfigureAwait(true);

            var campaign = await CreateCampaign();
            
            var createdFeedback = await this.MailChimpManager.Feedback.AddOrUpdateAsync(campaign.Id, new Feedback() {
                Message = "Test feedback"
            });

            var feedback = await this.MailChimpManager.Feedback.GetAsync(campaign.Id, createdFeedback.FeedbackId.Value.ToString());

            Assert.NotNull(feedback);
        }

        /// <summary>
        /// Should_Return_Feedback.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task Should_Return_Feedback()
        {
            var campaign = await CreateCampaign();
            var feedbacks = await this.MailChimpManager.Feedback.GetAllAsync(campaign.Id);
            Assert.NotNull(feedbacks);
        }

        /// <summary>
        /// Should_Return_Multiple_Feedback.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task Should_Return_Multiple_Feedback()
        {
            await this.ClearMailChimpAsync().ConfigureAwait(true);

            var campaign = await CreateCampaign();

            for (var i = 0; i < 3; i++)
            {
                await this.MailChimpManager.Feedback.AddOrUpdateAsync(campaign.Id, new Feedback()
                {
                    Message = "Test feedback"
                });
            }
            var feedbacks = await this.MailChimpManager.Feedback.GetAllAsync(campaign.Id);
            Assert.Equal(3, feedbacks.Count());
        }

        /// <summary>
        /// Should_Return_No_Feedback_After_Removal.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task Should_Return_No_Feedback_After_Removal()
        {
            await this.ClearMailChimpAsync().ConfigureAwait(true);

            var campaign = await CreateCampaign();

            var createdFeedback = await this.MailChimpManager.Feedback.AddOrUpdateAsync(campaign.Id, new Feedback()
            {
                Message = "Test feedback"
            });

            await this.MailChimpManager.Feedback.DeleteAsync(campaign.Id, createdFeedback.FeedbackId.Value.ToString());
            var feedback = await this.MailChimpManager.Feedback.GetAllAsync(campaign.Id);

            Assert.Empty(feedback);
        }

        private async Task<Campaign> CreateCampaign()
        {
            var campaign = await this.MailChimpManager.Campaigns.AddAsync(new Campaign
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