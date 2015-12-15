using System.Linq;
using System.Threading.Tasks;
using MailChimp.Net.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailChimp.Net.Tests
{
    [TestClass]
    public class ListMemberTest : MailChimpTest
    {
        [TestMethod]
        public async Task Should_Return_Six_Members()
        {
            var members = await _mailChimpManager.GetListMembersAsync("72dcc9fa45");
            Assert.IsTrue(members.Count() == 7);
        }

        [TestMethod]
        public async Task Add_User_To_List()
        {
            await
                _mailChimpManager.AddOrUpdateListMemberAsync("72dcc9fa45",
                    new Member { EmailAddress = "test@test.com", Status = Status.subscribed });
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
