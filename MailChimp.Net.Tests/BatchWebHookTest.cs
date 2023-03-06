// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AuthorizedAppTest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace MailChimp.Net.Tests;

/// <summary>
/// The api test.
/// </summary>
public class BatchWebHookTest : MailChimpTest
{
    /// <summary>
    /// The should_ return_ ap i_ information.
    /// </summary>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    [Fact]
    public async Task Should_Create_Batch_Webhook()
    {
        var batch = await this.MailChimpManager.Batches.AddAsync();
        var status = await this.MailChimpManager.Batches.GetBatchStatus(batch.Id);
        var batches = await this.MailChimpManager.BatchWebHooks.GetAllAsync().ConfigureAwait(false);
        await Task.WhenAll(batches.ToList().Select(x => this.MailChimpManager.BatchWebHooks.DeleteAsync(x.Id)));

        var apiInfo = await this.MailChimpManager.BatchWebHooks.AddAsync("http://asdfasdf.com").ConfigureAwait(false);
        Assert.NotNull(apiInfo);
    }
}