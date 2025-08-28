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
        var conversations = await this.MailChimpManager.Conversations.GetAllAsync();
        Assert.NotNull(conversations);
    }
}
