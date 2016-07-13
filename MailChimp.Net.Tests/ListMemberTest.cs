// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ListMemberTest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Threading.Tasks;

using MailChimp.Net.Models;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailChimp.Net.Tests
{
    /// <summary>
    /// The list member test.
    /// </summary>
    [TestClass]
    public class ListMemberTest : MailChimpTest
    {
        /// <summary>
        /// The _ticks.
        /// </summary>
        private readonly long _ticks = DateTime.Now.Ticks;

        [TestInitialize]
        public void InitilizeListMemberTest()
        {
            this.ClearMailChimpAsync().Wait();
            var createdList = this._mailChimpManager.Lists.AddOrUpdateAsync(this.MailChimpList).Result;
            this.TestList = createdList;
        }

        public List TestList { get; set; }


        /// <summary>
        /// The add_ user_ to_ list.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public async Task Add_User_To_List()
        {
            await
                this._mailChimpManager.Members.AddOrUpdateAsync(
                    this.TestList.Id, 
                    new Member { EmailAddress = $"{this._ticks}@test.com", Status = Status.Subscribed }).ConfigureAwait(false);
        }

        /// <summary>
        /// The should_ return_ members_ from_ list.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public async Task Should_Return_Members_From_List()
        {
            await this.Add_User_To_List();
            var members = await this._mailChimpManager.Members.GetAllAsync(this.TestList.Id);
            Assert.IsTrue(members.Any());
        }

        /// <summary>
        /// The should_ return_true_if_member_exists_in_list.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public async Task Should_Return_True_If_Member_Exists_In_List()
        {
            var emailAddress = $"{this._ticks}@test.com";
            await
                this._mailChimpManager.Members.AddOrUpdateAsync(
                    this.TestList.Id,
                    new Member { EmailAddress = emailAddress, Status = Status.Subscribed }).ConfigureAwait(false);

            var exists = await this._mailChimpManager.Members.ExistsAsync(this.TestList.Id, emailAddress);
            Assert.IsTrue(exists);
        }

        /// <summary>
        /// The should_ return_false_if_member_does_not_exist_in_list.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public async Task Should_Return_False_If_Member_Does_Not_Exists_In_List()
        {
            var emailAddress1 = $"{this._ticks}1@test.com";
            var emailAddress2 = $"{this._ticks}2@test.com";
            await
                this._mailChimpManager.Members.AddOrUpdateAsync(
                    this.TestList.Id,
                    new Member { EmailAddress = emailAddress1, Status = Status.Subscribed }).ConfigureAwait(false);

            var exists = await this._mailChimpManager.Members.ExistsAsync(this.TestList.Id, emailAddress2);
            Assert.IsFalse(exists);
        }

        /// <summary>
        /// The should_ return_ one_ unsubscribed_ member.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public async Task Should_Return_One_Unsubscribed_Member()
        {
            await this.Add_User_To_List();
            await this.Add_User_To_List();
            var members = await this._mailChimpManager.Members.GetAllAsync(this.TestList.Id);
            members.ToList().ForEach(
                async x =>
                    {
                        x.Status = Status.Subscribed;
                        await this._mailChimpManager.Members.AddOrUpdateAsync(this.TestList.Id, x);
                    });

            Assert.IsTrue(members.Count(x => x.Status == Status.Unsubscribed) == 0);

            var memberToUnsubscribe = members.FirstOrDefault();
            memberToUnsubscribe.Status = Status.Unsubscribed;
            await this._mailChimpManager.Members.AddOrUpdateAsync(this.TestList.Id, memberToUnsubscribe);

            members = await this._mailChimpManager.Members.GetAllAsync(this.TestList.Id);

            Assert.IsTrue(members.Count(x => x.Status == Status.Unsubscribed) == 1);
        }

        /// <summary>
        /// The subscribed_ user_ from_ list.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public async Task UPDATE_MERGE_FIELD_SHOULD_EQUAL()
        {
            await this.Add_User_To_List();
            var member = await this._mailChimpManager.Members.GetAsync(this.TestList.Id, $"{this._ticks}@test.com");
            member.MergeFields["FNAME"] = "HOLY COW";
            var returnedMember = await this._mailChimpManager.Members.AddOrUpdateAsync(this.TestList.Id, member).ConfigureAwait(false);
            Assert.AreEqual(returnedMember.MergeFields["FNAME"], "HOLY COW");
        }

        /// <summary>
        /// The unsubscribe_ user_ from_ list.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public async Task Unsubscribe_User_From_List()
        {
            await this.Add_User_To_List();
            var member = await this._mailChimpManager.Members.GetAsync(this.TestList.Id, $"{this._ticks}@test.com");
            member.Status = Status.Unsubscribed;
            var updatedMember = await this._mailChimpManager.Members.AddOrUpdateAsync(this.TestList.Id, member);
            Assert.AreEqual(member.Status, updatedMember.Status);
        }

        /// <summary>
        /// The add new member.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        private async Task AddNewMember()
        {
            var member = new Member { EmailAddress = $"{_ticks}@test.com", Status = Status.Subscribed };

            member.MergeFields.Add("FNAME", "HOLY COW");
            await this._mailChimpManager.Members.AddOrUpdateAsync(this.TestList.Id, member);
        }
    }
}