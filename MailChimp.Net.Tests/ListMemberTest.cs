// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ListMemberTest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using MailChimp.Net.Models;

using Xunit;

namespace MailChimp.Net.Tests
{
    /// <summary>
    /// The list member test.
    /// </summary>
    public class ListMemberTest : MailChimpTest
    {
        /// <summary>
        /// The _ticks.
        /// </summary>
        private readonly long _ticks = DateTime.Now.Ticks;

        public ListMemberTest()
        {
            this.ClearMailChimpAsync().Wait();
            var createdList = this.MailChimpManager.Lists.AddOrUpdateAsync(this.GetMailChimpList()).Result;
            var createdGdprList = this.MailChimpManager.Lists.AddOrUpdateAsync(this.GetGdprMailChimpList()).Result;
            this.TestList = createdList;
            this.GdprTestList = createdGdprList;
        }

        public List TestList { get; set; }
        public List GdprTestList { get; set; }

        /// <summary>
        /// The add_ user_ to_ list.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task Add_User_To_List()
        {
            var t = await
                this.MailChimpManager.Members.AddOrUpdateAsync(
                    this.TestList.Id,
                    new Member
                    {
                        EmailAddress = $"{this._ticks}@test.com",
                        Status = Status.Subscribed,
                        MergeFields = new System.Collections.Generic.Dictionary<string, object>{
                        { "FNAME", "HOLYYY" },
                        { "LNAME", "COW" }
                    }
                    }).ConfigureAwait(false);

            t.MergeFields["FNAME"] = "AWESOME";

            var updateMergeField =
                await

                                this.MailChimpManager.Members.AddOrUpdateAsync(
                    this.TestList.Id, t).ConfigureAwait(false);

        }

        /// <summary>
        /// The add_ user_ to_ Gdpr_ list.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task Add_User_To_Gdpr_List()
        {
            var t = await this.MailChimpManager.Members.AddOrUpdateAsync(
                this.GdprTestList.Id,
                new Member
                {
                    EmailAddress = $"{this._ticks}@test.com",
                    StatusIfNew = Status.Subscribed,
                    Status = Status.Subscribed,
                    MergeFields = new Dictionary<string, object>
                    {
                        { "FNAME", "HOLYYY" },
                        { "LNAME", "COW" }
                    }
                    
                }, 
                new List<MarketingPermissionText>
                {
                    MarketingPermissionText.Email,
                    MarketingPermissionText.CustomizedOnlineAdvertising,
                    MarketingPermissionText.DirectMail
                }).ConfigureAwait(false);

            t.MergeFields["FNAME"] = "AWESOME";

            var updateMergeField = await this.MailChimpManager.Members.AddOrUpdateAsync(
                this.GdprTestList.Id, t).ConfigureAwait(false);
        }

        /// <summary>
        /// The should_ return_ members_ from_ list.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task Should_Return_Members_From_List()
        {
            await this.Add_User_To_List();
            var members = await this.MailChimpManager.Members.GetAllAsync(this.TestList.Id);
            Assert.True(members.Any());
        }

        /// <summary>
        /// The should_ return_ members_ from_ Gdpr_ list.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task Should_Return_Members_From_Gdpr_List()
        {
            await this.Add_User_To_Gdpr_List();
            var members = await this.MailChimpManager.Members.GetAllAsync(this.GdprTestList.Id);
            Assert.True(members.Any());
        }

        /// <summary>
        /// The should_ return_true_if_member_exists_in_list.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task Should_Return_True_If_Member_Exists_In_List()
        {
            var emailAddress = $"{this._ticks}@test.com";
            await
                this.MailChimpManager.Members.AddOrUpdateAsync(
                    this.TestList.Id,
                    new Member { EmailAddress = emailAddress, Status = Status.Subscribed }).ConfigureAwait(false);

            var exists = await this.MailChimpManager.Members.ExistsAsync(this.TestList.Id, emailAddress);
            Assert.True(exists);
        }

        /// <summary>
        /// The should_ return_false_if_member_does_not_exist_in_list.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task Should_Return_False_If_Member_Does_Not_Exists_In_List()
        {
            var emailAddress1 = $"{this._ticks}1@test.com";
            var emailAddress2 = $"{this._ticks}2@test.com";
            await
                this.MailChimpManager.Members.AddOrUpdateAsync(
                    this.TestList.Id,
                    new Member { EmailAddress = emailAddress1, Status = Status.Subscribed }).ConfigureAwait(false);

            var exists = await this.MailChimpManager.Members.ExistsAsync(this.TestList.Id, emailAddress2);
            Assert.False(exists);
        }

        /// <summary>
        /// TShould_Not_Return_Any_Members_After_Delation.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task Should_Return_False_On_Exist_After_Removal()
        {
            var emailAddress = "tester@test.com";
            await
                this.MailChimpManager.Members.AddOrUpdateAsync(
                    this.TestList.Id,
                    new Member { EmailAddress = emailAddress }).ConfigureAwait(false);

            await
                this.MailChimpManager.Members.DeleteAsync(
                    this.TestList.Id,
                    emailAddress);

            var doesExists = await this.MailChimpManager.Members.ExistsAsync(this.TestList.Id, emailAddress);
            Assert.False(doesExists);
        }

        /// <summary>
        /// The should_ return_ one_ unsubscribed_ member.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task Should_Return_One_Unsubscribed_Member()
        {
            await this.Add_User_To_List();
            await this.Add_User_To_List();
            var members = await this.MailChimpManager.Members.GetAllAsync(this.TestList.Id);
            members.ToList().ForEach(
                async x =>
                    {
                        x.Status = Status.Subscribed;
                        await this.MailChimpManager.Members.AddOrUpdateAsync(this.TestList.Id, x);
                    });

            Assert.True(members.Count(x => x.Status == Status.Unsubscribed) == 0);

            var memberToUnsubscribe = members.FirstOrDefault();
            memberToUnsubscribe.Status = Status.Unsubscribed;
            await this.MailChimpManager.Members.AddOrUpdateAsync(this.TestList.Id, memberToUnsubscribe);

            members = await this.MailChimpManager.Members.GetAllAsync(this.TestList.Id);

            Assert.True(members.Count(x => x.Status == Status.Unsubscribed) == 1);
        }

        /// <summary>
        /// The subscribed_ user_ from_ list.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task UPDATE_MERGE_FIELD_SHOULD_EQUAL()
        {
            await this.Add_User_To_List();
            var member = await this.MailChimpManager.Members.GetAsync(this.TestList.Id, $"{this._ticks}@test.com");
            member.MergeFields["FNAME"] = "HOLY COW";

            var returnedMember = await this.MailChimpManager.Members.AddOrUpdateAsync(this.TestList.Id, member).ConfigureAwait(false);
            Assert.Equal("HOLY COW", returnedMember.MergeFields["FNAME"]);
        }

        /// <summary>
        /// The unsubscribe_ user_ from_ list.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task Unsubscribe_User_From_List()
        {
            await this.Add_User_To_List();
            var member = await this.MailChimpManager.Members.GetAsync(this.TestList.Id, $"{this._ticks}@test.com");
            member.Status = Status.Unsubscribed;

            var updatedMember = await this.MailChimpManager.Members.AddOrUpdateAsync(this.TestList.Id, member);
            Assert.Equal(member.Status, updatedMember.Status);
        }

        /// <summary>
        /// The search_ by_ user_ status.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task Search_By_User_Status()
        {
            await this.Add_User_To_List();
            var member = await this.MailChimpManager.Members.GetAsync(this.TestList.Id, $"{this._ticks}@test.com");
            member.Status = Status.Unsubscribed;

            var updatedMember = await this.MailChimpManager.Members.AddOrUpdateAsync(this.TestList.Id, member);
            Assert.Equal(member.Status, updatedMember.Status);

            var unsubscribedMembers = await this.MailChimpManager.Members.GetAllAsync(this.TestList.Id, new Core.MemberRequest { Status = Status.Unsubscribed });
            Assert.True(unsubscribedMembers.Count() == 1);
        }

        [Fact]
        public async Task Tags_are_saved_with_member()
        {
            var member = new Member
            {
                EmailAddress = $"{_ticks}@test.com",
                Status = Status.Subscribed,
                Tags = new List<MemberTag>
                {
                    new MemberTag() { Name = "Tag1"},
                    new MemberTag() { Name = "Tag2"},
                }
            };

            member = await this.MailChimpManager.Members.AddOrUpdateAsync(this.TestList.Id, member);

            member.Tags.Count.Should().Be(2);
            member.Tags.Select(t => t.Name).Should().BeEquivalentTo("Tag1", "Tag2");
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
            member = await this.MailChimpManager.Members.AddOrUpdateAsync(this.TestList.Id, member);
        }
    }
}