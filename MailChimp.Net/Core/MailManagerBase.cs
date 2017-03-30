// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MailManagerBase.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Interfaces;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The mail manager base.
    /// </summary>
    public abstract class MailManagerBase
    {
        protected IMailChimpConfiguration _mailChimpConfiguration;

        /// <summary>
        /// Initializes a new instance of the <see cref="MailManagerBase"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api key.
        /// </param>
        protected MailManagerBase(string apiKey)
        {
            _mailChimpConfiguration = new MailChimpConfiguration()
            {
                ApiKey = apiKey,
            };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MailManagerBase"/> class.
        /// </summary>
        /// <param name="mailChimpConfiguration">
        /// IMailChimpConfiguration.
        /// </param>
        protected MailManagerBase(IMailChimpConfiguration mailChimpConfiguration)
        {
            _mailChimpConfiguration = mailChimpConfiguration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MailManagerBase"/> class.
        /// </summary>
        protected MailManagerBase()
        {
            
        }
    }
}