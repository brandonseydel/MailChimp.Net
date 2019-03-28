// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ListTest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Linq;
using System.Threading.Tasks;
using MailChimp.Net.Models;
using Xunit;
using MailChimp.Net.Core;
using System;
using System.Collections.Generic;

namespace MailChimp.Net.Tests
{
    /// <summary>
    /// The list test.
    /// </summary>
    public class ListTest : MailChimpTest
    {
        private string TestListId { get; set; }

        /// <summary>
        /// The should_ delete_ all_ lists.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task Should_Delete_All_Lists()
        {

            var allLists = await this.MailChimpManager.Lists.GetAllAsync().ConfigureAwait(false);
            await Task.WhenAll(allLists.Select(x => this.MailChimpManager.Lists.DeleteAsync(x.Id))).ConfigureAwait(false);
            allLists = await this.MailChimpManager.Lists.GetAllAsync().ConfigureAwait(false);
            Assert.Equal(0, allLists.Count());
        }

        /// <summary>
        /// The should_ create_ new_ list.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task<List> Should_Create_New_List()
        {
            //Clear out all the lists
            await this.Should_Delete_All_Lists();

            var list = await this.MailChimpManager.Configure((mo) => mo.Limit = 10).Lists.AddOrUpdateAsync(this.GetMailChimpList()).ConfigureAwait(false);

            var allLists = await this.MailChimpManager.Lists.GetAllAsync().ConfigureAwait(false);
            Assert.True(allLists.Any());
            return list;
        }

        /// <summary>
        /// The should_ create_ new_ Gdpr_ list.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task<List> Should_Create_New_Gdpr_List()
        {
            //Clear out all the lists
            await this.Should_Delete_All_Lists();

            var list = await this.MailChimpManager.Configure((mo) => mo.Limit = 10).Lists.AddOrUpdateAsync(this.GetGdprMailChimpList()).ConfigureAwait(false);

            var allLists = await this.MailChimpManager.Lists.GetAllAsync().ConfigureAwait(false);
            Assert.True(allLists.Any());
            return list;
        }

        /// <summary>
        /// The should_ return_ lists.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task Should_Return_Lists()
        {
            var lists = await this.MailChimpManager.Lists.GetAllAsync();
            Assert.NotNull(lists);
        }
        /// <summary>
        /// The should_ return_ lists_created_today.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task Should_Return_Lists_Created_Today()
        {
            var request = new ListRequest()
            {
                BeforeDateCreated = DateTime.UtcNow,
                SinceDateCreated = DateTime.UtcNow.AddDays(-1)
            };
            
            var lists = await this.MailChimpManager.Lists.GetAllAsync(request);
            Assert.NotNull(lists);
        }

        /// <summary>
        /// The should_ return_ one_ list.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task Should_Return_One_List()
        {
            var newList = await this.Should_Create_New_List().ConfigureAwait(false);
            var lists = await this.MailChimpManager.Lists.GetAsync(newList.Id).ConfigureAwait(false);
            Assert.NotNull(lists);
        }

        /// <summary>
        /// The should_ update_ list_ name.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task Should_Update_List_Name()
        {
            var newList = await this.Should_Create_New_List().ConfigureAwait(false);
            newList.Name = "TEST2";
            var updatedList = await this.MailChimpManager.Lists.AddOrUpdateAsync(newList).ConfigureAwait(false);
            Assert.Equal(updatedList.Name, newList.Name);
        }

        [Fact]
        public async Task Should_Batch_List_Update_Name()
        {
            var newList = await this.Should_Create_New_List().ConfigureAwait(false);
            var testEmail = $"test{Guid.NewGuid()}@yandex.ru";

            var updatedList = await this.MailChimpManager.Lists.BatchAsync(new BatchList()
            {
                Members = new List<Member>()
                {
                    new Member()
                    {
                        EmailAddress = testEmail,
                        Status = Status.Subscribed,
                        StatusIfNew = Status.Subscribed
                    },
                    new Member()
                    {
                        EmailAddress = $"test{Guid.NewGuid()}@yandex.ru",
                        Status = Status.Unsubscribed,
                        StatusIfNew = Status.Unsubscribed
                    },
                },
                UpdateExisting = false
            }, newList.Id);

            Assert.True(updatedList.NewMembers.Any(x => x.EmailAddress == testEmail));
        }
    }
}