using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;

namespace MailChimp.Net.Tests
{
    /// <summary>
    /// OAUTH Authorization test.
    /// </summary>
    [TestClass]
    public class OauthTest : MailChimpTest
    {
        /// <summary>
        /// The should_ return_ ap i_ information.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public async Task Should_Return_API_Information()
        {
            var oauthmailChimpManager = new MailChimpManager(new MailChimpOauthConfiguration
            {
                DataCenter = ConfigurationManager.AppSettings["MailChimpOauthDataCenter"],
                OauthToken = ConfigurationManager.AppSettings["MailChimpOauthToken"],
            });

            var apiInfo = await oauthmailChimpManager.Api.GetInfoAsync().ConfigureAwait(false);
            Assert.IsNotNull(apiInfo);
        }
    }
}
