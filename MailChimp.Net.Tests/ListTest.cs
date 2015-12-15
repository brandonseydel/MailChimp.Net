using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailChimp.Net.Tests
{
    [TestClass]
    public class ListTest : MailChimpTest
    {
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
    }
}
