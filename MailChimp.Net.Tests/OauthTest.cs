using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace MailChimp.Net.Tests;

/// <summary>
/// OAUTH Authorization test.
/// </summary>
public class OauthTest : MailChimpTest
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
        var apiInfo = await base.MailChimpManager.Api.GetInfoAsync().ConfigureAwait(false);
        Assert.NotNull(apiInfo);
    }
}
