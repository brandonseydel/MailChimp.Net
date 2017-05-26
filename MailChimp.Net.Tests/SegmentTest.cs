using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailChimp.Net.Tests
{
    [TestClass]
    public class SegmentTest : MailChimpTest
    {
        [TestMethod]
        public async Task Should_Get_Segment()
        {
            var lists = await this.MailChimpManager.Lists.GetAllAsync().ConfigureAwait(false);
            var listId = lists.First().Id;

            var segment = new Segment()
            {
                Name = DateTime.Now.ToString(),
                Options = new SegmentOptions()
                {
                    Match = "all",
                    Conditions = new List<Condition>()
                }
            };

            var createdSegment = await this.MailChimpManager.ListSegments.AddAsync(listId, segment).ConfigureAwait(false);

            var retrievedSegment = await this.MailChimpManager.ListSegments.GetAsync(listId, createdSegment.Id).ConfigureAwait(false);

            Assert.IsNotNull(retrievedSegment);
            Assert.IsTrue(createdSegment.Id == retrievedSegment.Id);

        }
    }
}
