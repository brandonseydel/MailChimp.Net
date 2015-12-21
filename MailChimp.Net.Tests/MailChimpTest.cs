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
            _mailChimpManager = new MailChimpManager();
        }
    }
}