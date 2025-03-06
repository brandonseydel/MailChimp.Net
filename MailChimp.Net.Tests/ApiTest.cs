// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AuthorizedAppTest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Threading.Tasks;
using MailChimp.Net.Core;
using Xunit;

namespace MailChimp.Net.Tests
{
    /// <summary>
    /// The api test.
    /// </summary>
    public class ApiTest : MailChimpTest
    {
        /// <summary>
        /// The should_ return_ ap i_ information.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task Should_Return_API_Information()
        {
            var apiInfo = await this.MailChimpManager.Api.GetInfoAsync().ConfigureAwait(false);
            Assert.NotNull(apiInfo);
        }

        [Fact]
        public async Task Should_Return_String_From_Ping()
        {
            var ping = await this.MailChimpManager.Api.PingAsync().ConfigureAwait(false);
            Assert.Equal(ping.HealthStatus, Constants.MailChimpHealthCheck);
        }
    }
}