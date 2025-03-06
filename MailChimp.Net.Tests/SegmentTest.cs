using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;
using Xunit;

namespace MailChimp.Net.Tests
{
    public class SegmentTest : MailChimpTest
    {
        [Fact]
        public async Task Should_Get_Segment()
        {
            try
            {
                var createList = await this.MailChimpManager.Lists.AddOrUpdateAsync(this.GetMailChimpList());
                var lists = await this.MailChimpManager.Lists.GetAllAsync().ConfigureAwait(false);
                var listId = lists.First().Id;

                var segment = new Segment()
                {
                    Name = DateTime.Now.ToString(),
                    Options = new SegmentOptions()
                    {
                        Match = Match.All,
                        Conditions = new List<Condition>()
                    }
                };

                var createdSegment = await this.MailChimpManager.ListSegments.AddAsync(listId, segment).ConfigureAwait(false);

                var retrievedSegment = await this.MailChimpManager.ListSegments.GetAsync(listId, createdSegment.Id).ConfigureAwait(false);

                Assert.NotNull(retrievedSegment);
                Assert.True(createdSegment.Id == retrievedSegment.Id);
            }catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}
