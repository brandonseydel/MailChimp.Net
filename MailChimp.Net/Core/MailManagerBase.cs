// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MailManagerBase.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The mail manager base.
    /// </summary>
    public abstract class MailManagerBase
    {
        protected readonly MailChimpOptions MailChimpOptions;

        /// <summary>
        /// Initializes a new instance of the <see cref="MailManagerBase"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api key.
        /// </param>
        public MailManagerBase(string apiKey) => MailChimpOptions = new MailChimpOptions
        {
            ApiKey = apiKey,
        };
        
        /// <summary>
        /// Initializes a new instance of the <see cref="MailManagerBase"/> class.
        /// </summary>
        /// <param name="mailChimpConfiguration">
        /// MailchimpOptions.
        /// </param>
        protected MailManagerBase(IOptions<MailChimpOptions> optionsAccessor) => MailChimpOptions = optionsAccessor.Value;

        /// <summary>
        /// Initializes a new instance of the <see cref="MailManagerBase"/> class.
        /// </summary>
        protected MailManagerBase()
        {

        }
    }
}