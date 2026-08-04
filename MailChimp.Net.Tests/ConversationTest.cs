// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CampaignTest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Threading.Tasks;

using Xunit;

namespace MailChimp.Net.Tests;

/// <summary>
/// The conversation test.
/// </summary>
public class ConversationTest : MailChimpTest
{
    /// <summary>
    /// The should_ return_ conversations.
    /// </summary>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    [Fact]
    public async Task Should_Return_Conversations()
    {
#pragma warning disable CS0618 // Conversations kept for backward compatibility coverage
        var conversations = await this.MailChimpManager.Conversations.GetAllAsync();
#pragma warning restore CS0618
        Assert.NotNull(conversations);
    }
}
