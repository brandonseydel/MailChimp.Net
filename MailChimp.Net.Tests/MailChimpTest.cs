// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MailChimpTest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Security.Cryptography;

using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailChimp.Net.Tests
{
    /// <summary>
    /// The mail chimp test.
    /// </summary>
    public abstract class MailChimpTest
    {
        /// <summary>
        /// The _mail chimp manager.
        /// </summary>
        protected IMailChimpManager _mailChimpManager;

        /// <summary>
        /// The initialize.
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            this._mailChimpManager = new MailChimpManager();
        }

        /// <summary>
        /// The hash.
        /// </summary>
        /// <param name="emailAddress">
        /// The email address.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        internal string Hash(string emailAddress)
        {
            using (var md5 = MD5.Create()) return md5.GetHash(emailAddress);
        }
    }
}