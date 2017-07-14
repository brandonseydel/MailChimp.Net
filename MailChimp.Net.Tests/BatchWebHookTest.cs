// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AuthorizedAppTest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Linq;
using System.Threading.Tasks;
using MailChimp.Net.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailChimp.Net.Tests
{
    /// <summary>
    /// The api test.
    /// </summary>
    [TestClass]
    public class BatchWebHookTest : MailChimpTest
    {
        /// <summary>
        /// The should_ return_ ap i_ information.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public async Task Should_Create_Batch_Webhook()
        {

            var batches = await this.MailChimpManager.BatchWebHooks.GetAllAsync().ConfigureAwait(false);
            Task.WhenAll(batches.ToList().Select(x => this.MailChimpManager.BatchWebHooks.DeleteAsync(x.Id)));

            var apiInfo = await this.MailChimpManager.BatchWebHooks.AddAsync("http://asdfasdf.com").ConfigureAwait(false);
            Assert.IsNotNull(apiInfo);
        }
    }
}