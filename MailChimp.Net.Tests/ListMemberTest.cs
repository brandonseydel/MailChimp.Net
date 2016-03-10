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
        private static readonly long _ticks = DateTime.Now.Ticks;

        /// <summary>
        /// The add_ new_ user_ to_ list.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public async Task Add_New_User_To_List()
        {
            await this.AddNewMember();
        }

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
                    "72dcc9fa45", 
                    new Member { EmailAddress = "test@test.com", Status = Status.Subscribed });
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
            var members = await this._mailChimpManager.Members.GetAllAsync("72dcc9fa45");
            Assert.IsTrue(members.Any());
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
            var members = await this._mailChimpManager.Members.GetAllAsync("72dcc9fa45");
            members.ToList().ForEach(
                async x =>
                    {
                        x.Status = Status.Subscribed;
                        await this._mailChimpManager.Members.AddOrUpdateAsync("72dcc9fa45", x);
                    });

            Assert.IsTrue(members.Count(x => x.Status == Status.Unsubscribed) == 0);

            var memberToUnsubscribe = members.FirstOrDefault();
            memberToUnsubscribe.Status = Status.Unsubscribed;
            await this._mailChimpManager.Members.AddOrUpdateAsync("72dcc9fa45", memberToUnsubscribe);

            members = await this._mailChimpManager.Members.GetAllAsync("72dcc9fa45");

            Assert.IsTrue(members.Count(x => x.Status == Status.Unsubscribed) == 1);
        }

        /// <summary>
        /// The subscribed_ user_ from_ list.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public async Task Subscribed_User_From_List()
        {
            var member = new Member { EmailAddress = "test@test.com", Status = Status.Subscribed };

            member.MergeFields.Add("FNAME", "HOLY COW");
            await this._mailChimpManager.Members.AddOrUpdateAsync("72dcc9fa45", member);
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
            var member = new Member { EmailAddress = "test@test.com", Status = Status.Unsubscribed };

            member.MergeFields.Add("FNAME", "HOLY COW");
            await this._mailChimpManager.Members.AddOrUpdateAsync("72dcc9fa45", member);
        }

        /// <summary>
        /// The update_ existing_ member_ from_ list.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public async Task Update_Existing_Member_From_List()
        {
            await this.AddNewMember();

            var member = new Member { Status = Status.Subscribed, EmailAddress = $"{_ticks}@test.com" };

            member.MergeFields.Add("FNAME", "HOLY COW");
            var updateMember = await this._mailChimpManager.Members.AddOrUpdateAsync("72dcc9fa45", member);
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
            await this._mailChimpManager.Members.AddOrUpdateAsync("72dcc9fa45", member);
        }
    }
}