// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApiTest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Linq;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailChimp.Net.Tests
{
    /// <summary>
    /// The authorized app test.
    /// </summary>
    [TestClass]
    public class ECommerceLogicTest : MailChimpTest
    {
        /// <summary>
        /// The should_ return_ app_ information.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public async Task Should_Return_App_Information()
        {
            try
            {
                var stores = await this.MailChimpManager.ECommerceStores.GetAllAsync();
                await Task.WhenAll(stores.Select(x => this.MailChimpManager.ECommerceStores.DeleteAsync(x.Id)));
                var testStore = await this.MailChimpManager.ECommerceStores.AddAsync(new Store {Name = "TestStore"});
                var testCart = await this.MailChimpManager.ECommerceStores.Carts(testStore.Id).AddAsync(new Cart
                {


                });
                Assert.IsNotNull(testStore);
            }
            catch (MailChimpException ex)
            {
                
            }

            //await this._mailChimpManager.ECommerceStores.Products("storeId").Variances("productId");

        }
    }
}