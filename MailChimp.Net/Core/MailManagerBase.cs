// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MailManagerBase.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Configuration;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The mail manager base.
    /// </summary>
    public abstract class MailManagerBase
    {
        /// <summary>
        /// The _api key.
        /// </summary>
        private string _apiKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="MailManagerBase"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api key.
        /// </param>
        protected MailManagerBase(string apiKey)
        {
            _apiKey = apiKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MailManagerBase"/> class.
        /// </summary>
        protected MailManagerBase()
        {
        }

        /// <summary>
        /// Gets or sets the api key.
        /// </summary>
        protected string ApiKey
        {
            get
            {
                return _apiKey ?? ConfigurationManager.AppSettings["MailChimpApiKey"];
            }

            set
            {
                _apiKey = value;
            }
        }
    }
}