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
        public async Task Should_Return_Members_From_List()
        {
            var members = await _mailChimpManager.Members.GetAllAsync("72dcc9fa45");
            Assert.IsTrue(members.Any());
        }

        [TestMethod]
        public async Task Add_User_To_List()
        {
            await
                _mailChimpManager.Members.AddOrUpdateAsync("72dcc9fa45",
                    new Member { EmailAddress = "test@test.com", Status = Status.Subscribed });
        }

        [TestMethod]
        public async Task Get_User_By_Hashed_Email()
        {
            await Add_User_To_List();
            Assert.IsNotNull(await _mailChimpManager.Members.GetAsync("72dcc9fa45", Hash("test@test.com"), true));
        }


        [TestMethod]
        public async Task Unsubscribe_User_From_List()
        {
            var member = new Member
            {
                EmailAddress = "test@test.com",
                Status = Status.Unsubscribed
            };

            member.MergeFields.Add("FNAME", "HOLY COW");
            await _mailChimpManager.Members.AddOrUpdateAsync("72dcc9fa45", member);
        }

        [TestMethod]
        public async Task Subscribe_User_From_List()
        {

            var member = new Member
            {
                EmailAddress = "test@test.com",
                Status = Status.Subscribed
            };

            member.MergeFields.Add("FNAME", "HOLY COW");
            await _mailChimpManager.Members.AddOrUpdateAsync("72dcc9fa45", member);
        }

        [TestMethod]
        public async Task Should_Return_One_Unsubscribed_Member()
        {
            var members = await _mailChimpManager.Members.GetAllAsync("72dcc9fa45");
            members.ToList().ForEach(async x =>
            {
                x.Status = Status.Subscribed;
                await _mailChimpManager.Members.AddOrUpdateAsync("72dcc9fa45", x);
            });

            Assert.IsTrue(members.Count(x => x.Status == Status.Unsubscribed) == 0);

            var memberToUnsubscribe = members.FirstOrDefault();
            memberToUnsubscribe.Status = Status.Unsubscribed;
            await _mailChimpManager.Members.AddOrUpdateAsync("72dcc9fa45", memberToUnsubscribe);


            members = await _mailChimpManager.Members.GetAllAsync("72dcc9fa45");


            Assert.IsTrue(members.Count(x => x.Status == Status.Unsubscribed) == 1);


        }
    }
}
