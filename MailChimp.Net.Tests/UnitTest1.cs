using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailChimp.Net.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailChimp.Net.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private MailChimpManager _mailChimpManager;

        [TestInitialize]
        public void Initialize()
        {
            _mailChimpManager = new MailChimpManager("92959022783b0bdf7cefe5b56d770269-us10");
        }
        [TestMethod]
        public async Task TestMethod1()
        {
            var lists = await _mailChimpManager.GetListsAsync();
            Assert.IsNotNull(lists);
        }

        [TestMethod]
        public async Task Should_Return_One_List()
        {
            var lists = await _mailChimpManager.GetListAsync("72dcc9fa45");
            Assert.IsNotNull(lists);
        }

        [TestMethod]
        public async Task Should_Return_Six_Members()
        {
            var members = await _mailChimpManager.GetListMembersAsync("72dcc9fa45");
            Assert.IsTrue(members.Count() == 6);
        }

        [TestMethod]
        public async Task Add_User_To_List()
        {
            await
                _mailChimpManager.AddOrUpdateListMemberAsync("72dcc9fa45",
                    new Member { EmailAddress = "test@test.com", Status = Status.subscribed});
        }

        [TestMethod]
        public async Task Unsubscribe_User_From_List()
        {
            var member = new Member
            {
                EmailAddress = "test@test.com",
                Status = Status.unsubscribed
            };

            member.MergeFields.Add("FNAME", "HOLY COW");
            await _mailChimpManager.AddOrUpdateListMemberAsync("72dcc9fa45", member);
        }

        [TestMethod]
        public async Task Subscribed_User_From_List()
        {

            var member = new Member
            {
                EmailAddress = "test@test.com",
                Status = Status.subscribed
            };

            member.MergeFields.Add("FNAME", "HOLY COW");
            await _mailChimpManager.AddOrUpdateListMemberAsync("72dcc9fa45", member);
        }

        [TestMethod]
        public async Task Should_Return_Seven_Members()
        {
            var members = await _mailChimpManager.GetListMemberAsync("72dcc9fa45", "test@test.com");
            
        }
    }
}
