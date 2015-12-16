using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailChimp.Net.Tests
{
    [TestClass]
    public class ApiTest : MailChimpTest
    {
        [TestMethod]
        public async Task Should_Return_API_Information()
        {
            var apiInfo = await _mailChimpManager.GetApiInfoAsync();
            Assert.IsNotNull(apiInfo);
        }
    }
}
