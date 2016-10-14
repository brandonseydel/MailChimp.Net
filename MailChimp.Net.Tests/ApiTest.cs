﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AuthorizedAppTest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Threading.Tasks;
using MailChimp.Net.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailChimp.Net.Tests
{
    /// <summary>
    /// The api test.
    /// </summary>
    [TestClass]
    public class ApiTest : MailChimpTest
    {
        /// <summary>
        /// The should_ return_ ap i_ information.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public async Task Should_Return_API_Information()
        {
            var apiInfo = await this._mailChimpManager.Api.GetInfoAsync();
            Assert.IsNotNull(apiInfo);
        }
    }
}