using System.Threading.Tasks;
using MailChimp.Net.Tests.Stubs;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace MailChimp.Net.Tests
{
    /// <summary>
    /// OAUTH Authorization test.
    /// </summary>
    public class OauthTest : MailChimpTest
    {
        public OauthTest()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile("logging.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        /// <summary>
        /// The should_ return_ ap i_ information.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task Should_Return_API_Information()
        {
            var oauthmailChimpManager = new MailChimpManager(
                new StubMailchimpOptions(Configuration["MailChimpOauthDataCenter"].ToString(), Configuration["MailChimpOauthToken"].ToString()));

            var apiInfo = await oauthmailChimpManager.Api.GetInfoAsync().ConfigureAwait(false);
            Assert.NotNull(apiInfo);
        }
    }
}
