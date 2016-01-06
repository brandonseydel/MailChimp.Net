using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MailChimp.Net.Interfaces;

namespace MailChimp.Net.Tests
{
    [TestClass]
    public class ListTest : MailChimpTest
    {
        [TestMethod]
        public async Task Should_Return_Lists()
        {
            var lists = await _mailChimpManager.Lists.GetAllAsync();
            Assert.IsNotNull(lists);
        }

        [TestMethod]
        public async Task Should_Return_One_List()
        {
            var lists = await _mailChimpManager.Lists.GetAsync("72dcc9fa45");
            Assert.IsNotNull(lists);
        }

        [TestMethod]
        public async Task Test_Configuration_Key()
        {
            _mailChimpManager = new MailChimpManager();
            var lists = await _mailChimpManager.Lists.GetAsync("72dcc9fa45");
            Assert.IsNotNull(lists);
        }
    }
   
    

}
