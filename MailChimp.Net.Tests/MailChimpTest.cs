using System.Security.Cryptography;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailChimp.Net.Tests
{
    public abstract class MailChimpTest
    {
        protected IMailChimpManager _mailChimpManager;

        [TestInitialize]
        public void Initialize()
        {
            _mailChimpManager = new MailChimpManager("92959022783b0bdf7cefe5b56d770269-us10");
        }

        internal string Hash(string emailAddress)
        {
            using (var md5 = MD5.Create())
            {
                return md5.GetMd5Hash(emailAddress);
            }
        }

    }
}