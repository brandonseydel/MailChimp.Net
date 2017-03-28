// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApiTest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Threading.Tasks;

using Xunit;

namespace MailChimp.Net.Tests
{
    /// <summary>
    /// The authorized app test.
    /// </summary>
    public class AuthorizedAppTest : MailChimpTest
    {
        /// <summary>
        /// The should_ return_ app_ information.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task Should_Return_App_Information()
        {
            var apiInfo = await this.MailChimpManager.Apps.GetAllAsync();
            apiInfo = await this.MailChimpManager.Configure(new MailChimpConfiguration
            {
                Limit = 100000
            }).Apps.GetAllAsync();
            Assert.NotNull(apiInfo);
        }
    }
}