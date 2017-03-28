using System.Threading.Tasks;
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
            var oauthmailChimpManager = new MailChimpManager(new MailChimpOauthConfiguration
            {
                DataCenter = Configuration["MailChimpOauthDataCenter"],
                OauthToken = Configuration["MailChimpOauthToken"],
            });

            var apiInfo = await oauthmailChimpManager.Api.GetInfoAsync().ConfigureAwait(false);
            Assert.NotNull(apiInfo);
        }
    }
}
