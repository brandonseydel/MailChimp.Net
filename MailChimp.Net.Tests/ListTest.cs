// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ListTest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Linq;
using System.Threading.Tasks;
using MailChimp.Net.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MailChimp.Net.Core;
using System;

namespace MailChimp.Net.Tests
{
    /// <summary>
    /// The list test.
    /// </summary>
    [TestClass]
    public class ListTest : MailChimpTest
    {
        private string TestListId { get; set; }

        /// <summary>
        /// The should_ delete_ all_ lists.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public async Task Should_Delete_All_Lists()
        {
            var allLists = await this._mailChimpManager.Lists.GetAllAsync().ConfigureAwait(false);
            await Task.WhenAll(allLists.Select(x => this._mailChimpManager.Lists.DeleteAsync(x.Id))).ConfigureAwait(false);
            allLists = await this._mailChimpManager.Lists.GetAllAsync().ConfigureAwait(false);
            Assert.IsTrue(allLists.Count() == 0);
        }

        /// <summary>
        /// The should_ create_ new_ list.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public async Task<List> Should_Create_New_List()
        {
            //Clear out all the lists
            await this.Should_Delete_All_Lists();

            var list = await this._mailChimpManager.Configure(new MailChimpConfiguration
            {
                Limit = 10
            }).Lists.AddOrUpdateAsync(this.GetMailChimpList()).ConfigureAwait(false);

            var allLists = await this._mailChimpManager.Lists.GetAllAsync().ConfigureAwait(false);
            Assert.IsTrue(allLists.Count() > 0);
            return list;
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
        /// The should_ return_ lists_created_today.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public async Task Should_Return_Lists_Created_Today()
        {
            var request = new ListRequest()
            {
                BeforeDateCreated = DateTime.UtcNow,
                SinceDateCreated = DateTime.UtcNow.AddDays(-1)
            };

            var lists = await this._mailChimpManager.Lists.GetAllAsync(request);
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

        /// <summary>
        /// The should_ update_ list_ name.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
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