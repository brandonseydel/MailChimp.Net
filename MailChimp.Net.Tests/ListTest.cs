// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ListTest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailChimp.Net.Tests
{
    /// <summary>
    /// The list test.
    /// </summary>
    [TestClass]
    public class ListTest : MailChimpTest
    {
        /// <summary>
        /// The should_ return_ lists.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public async Task Should_Return_Lists()
        {
            var lists = await this._mailChimpManager.Lists.GetAllAsync();
            Assert.IsNotNull(lists);
        }

        /// <summary>
        /// The should_ return_ one_ list.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public async Task Should_Return_One_List()
        {
            var lists = await this._mailChimpManager.Lists.GetAsync("72dcc9fa45");
            Assert.IsNotNull(lists);
        }

        /// <summary>
        /// The test_ configuration_ key.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public async Task Test_Configuration_Key()
        {
            this._mailChimpManager = new MailChimpManager();
            var lists = await this._mailChimpManager.Lists.GetAsync("72dcc9fa45");
            Assert.IsNotNull(lists);
        }
    }
}