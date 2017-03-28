// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApiTest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Linq;
using System.Threading.Tasks;
using MailChimp.Net.Models;
using Xunit;

namespace MailChimp.Net.Tests
{
    /// <summary>
    /// The authorized app test.
    /// </summary>
    public class ECommerceLogicTest : MailChimpTest
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
            var stores = await this.MailChimpManager.ECommerceStores.GetAllAsync();
            await Task.WhenAll(stores.Select(x => this.MailChimpManager.ECommerceStores.DeleteAsync(x.Id)));
            var testStore = await this.MailChimpManager.ECommerceStores.AddAsync(new Store {Name = "TestStore"});
            var testCart = await this.MailChimpManager.ECommerceStores.Carts(testStore.Id).AddAsync(new Cart
            {
                

            });
            Assert.NotNull(testStore);

            //await this._mailChimpManager.ECommerceStores.Products("storeId").Variances("productId");

        }
    }
}