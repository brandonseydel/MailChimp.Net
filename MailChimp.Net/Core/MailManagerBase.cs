// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MailManagerBase.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Microsoft.Extensions.Options;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The mail manager base.
    /// </summary>
    public abstract class MailManagerBase
    {
        protected readonly MailchimpOptions MailchimpOptions;

        /// <summary>
        /// Initializes a new instance of the <see cref="MailManagerBase"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api key.
        /// </param>
        protected MailManagerBase(string apiKey)
        {
            MailchimpOptions = new MailchimpOptions
            {
                ApiKey = apiKey,
            };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MailManagerBase"/> class.
        /// </summary>
        /// <param name="mailChimpConfiguration">
        /// MailchimpOptions.
        /// </param>
        protected MailManagerBase(IOptions<MailchimpOptions> optionsAccessor)
        {
            MailchimpOptions = optionsAccessor.Value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MailManagerBase"/> class.
        /// </summary>
        protected MailManagerBase()
        {
            
        }
    }
}