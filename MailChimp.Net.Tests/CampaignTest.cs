using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using MailChimp.Net.Core;

namespace MailChimp.Net.Tests
{
    [TestClass]
    public class ConversationTest : MailChimpTest
    {
        [TestMethod]
        public async Task Should_Return_Conversations()
        {
            var conversations = await _mailChimpManager.Conversations.GetAllAsync();
            Assert.IsNotNull(conversations);
        }
    }
}
