using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace MailChimp.Net.Tests
{
    [TestClass]
    public class CampaignTest : MailChimpTest
    {
        [TestMethod]
        public async Task Should_Return_Campaigns()
        {
            var campaigns = await _mailChimpManager.Campaigns.GetAll();
            Assert.IsNotNull(campaigns);
        }

        [TestMethod]
        public async Task Should_Return_One_Campaign()
        {
            var campaigns = await _mailChimpManager.Campaigns.GetAll(new Requests.CampaignRequest { Limit = 1 });
            Assert.IsTrue(campaigns.Count() == 1);
        }

        [TestMethod]
        public async Task Should_Get_One_Campain_Id_And_Get_Campaign()
        {
            var campaigns = await _mailChimpManager.Campaigns.GetAll(new Requests.CampaignRequest { Limit = 1 });
            Assert.IsTrue(campaigns.Count() == 1);

            var campaign = await _mailChimpManager.Campaigns.GetAsync(campaigns.FirstOrDefault().Id);

            Assert.IsNotNull(campaign);

        }
    }
}
