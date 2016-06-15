// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApiTest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Threading.Tasks;

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
            var apiInfo = await this._mailChimpManager.ECommerceStores.Carts("asdfd").GetAllAsync();
            Assert.IsNotNull(apiInfo);


            await this._mailChimpManager.ECommerceStores.Products("storeId").Variances("productId")

        }
    }
}