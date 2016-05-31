// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CampaignTest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailChimp.Net.Tests
{
    /// <summary>
    /// The conversation test.
    /// </summary>
    [TestClass]
    public class ConversationTest : MailChimpTest
    {
        /// <summary>
        /// The should_ return_ conversations.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public async Task Should_Return_Conversations()
        {
            var conversations = await this._mailChimpManager.Conversations.GetAllAsync();
            Assert.IsNotNull(conversations);
        }
    }
}
