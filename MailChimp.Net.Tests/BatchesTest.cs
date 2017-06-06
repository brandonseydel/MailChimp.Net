using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace MailChimp.Net.Tests
{
    [TestClass]
    public class BatchesTest : MailChimpTest
    {
        /// <summary>
        /// The should_ return_ operations_ results.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public async Task Should_Return_Operations_Results()
        {
            var member = new Member()
            {
                EmailAddress = "member@gmail.com"
            };

            var serializedMember = JsonConvert.SerializeObject(member);

            var operation = new Operation()
            {
                Method = "POST",
                OperationId = "post",
                Path = "list/1234/members",
                Body = serializedMember
                
            };
            var operations = new List<Operation>()
            {
                operation
            };
            var batchRequest = new BatchRequest()
            {
                Operations = operations
            };
            var batchInfo = await this.MailChimpManager.Batches.AddAsync(batchRequest);
            await Task.Delay(10000);
            var operationResponses = await this.MailChimpManager.Batches.GetOperationResponsesAsync(batchInfo.Id);

            Assert.IsNotNull(operationResponses);
            Assert.IsTrue(operationResponses.Any());
        }
    }
}
