// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ListTest.cs" company="Brandon Seydel">
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
    /// The list test.
    /// </summary>
    [TestClass]
    public class ListTest : MailChimpTest
    {
        private string TestListId { get; set; }


        [TestMethod]
        public async Task Should_Delete_List()
        {
            var allLists = await this._mailChimpManager.Lists.GetAllAsync().ConfigureAwait(false);
            await Task.WhenAll(allLists.Select(x => this._mailChimpManager.Lists.DeleteAsync(x.Id))).ConfigureAwait(false);
        }

        [TestMethod]
        public async Task<List> Should_Create_New_List()
        {
            //Clear out all the lists
            this.Should_Delete_List();

            return await this._mailChimpManager.Configure(new MailChimpConfiguration
            {
                Limit = 10
            }).Lists.AddOrUpdateAsync(this.MailChimpList).ConfigureAwait(false);
        }


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
            var newList = await this.Should_Create_New_List().ConfigureAwait(false);
            var lists = await this._mailChimpManager.Lists.GetAsync(newList.Id).ConfigureAwait(false);
            Assert.IsNotNull(lists);
        }

        [TestMethod]
        public async Task Should_Update_List_Name()
        {
            var newList = await this.Should_Create_New_List().ConfigureAwait(false);
            newList.Name = "TEST2";
            var updatedList = await this._mailChimpManager.Lists.AddOrUpdateAsync(newList).ConfigureAwait(false);
            Assert.IsTrue(newList.Name.Equals(updatedList.Name));
        }

    }
}