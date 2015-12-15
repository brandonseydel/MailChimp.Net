using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailChimp.Net.Tests
{
    public abstract class MailChimpTest
    {
        protected MailChimpManager _mailChimpManager;

        [TestInitialize]
        public void Initialize()
        {
            _mailChimpManager = new MailChimpManager("92959022783b0bdf7cefe5b56d770269-us10");
        }
    }
}