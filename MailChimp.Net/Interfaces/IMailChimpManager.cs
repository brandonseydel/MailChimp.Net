// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IMailChimpManager.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace MailChimp.Net.Interfaces
{
    /// <summary>
    /// The MailChimpManager interface.
    /// </summary>
    public interface IMailChimpManager
    {
        /// <summary>
        /// Gets the api.
        /// </summary>
        IApiLogic Api { get; }

        /// <summary>
        /// Gets the apps.
        /// </summary>
        IAuthorizedAppLogic Apps { get; }

        /// <summary>
        /// Gets the campaigns.
        /// </summary>
        ICampaignLogic Campaigns { get; }

        /// <summary>
        /// Gets the content.
        /// </summary>
        IContentLogic Content { get; }

        /// <summary>
        /// Gets the conversations.
        /// </summary>
        IConversationLogic Conversations { get; }

        /// <summary>
        /// Gets the lists.
        /// </summary>
        IListLogic Lists { get; }

        /// <summary>
        /// Gets the members.
        /// </summary>
        IMemberLogic Members { get; }

        /// <summary>
        /// Gets the members.
        /// </summary>
        INoteLogic Notes { get; }
    }
}