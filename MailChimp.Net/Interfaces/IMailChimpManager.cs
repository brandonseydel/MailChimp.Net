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

        /// <summary>
        /// Gets the abuse reports.
        /// </summary>
        IAbuseReportLogic AbuseReports { get; }

        /// <summary>
        /// Gets the activities.
        /// </summary>
        IActivityLogic Activities { get; }

        /// <summary>
        /// Gets or sets the automation email queues.
        /// </summary>
        IAutomationEmailQueueLogic AutomationEmailQueues { get; }

        /// <summary>
        /// Gets or sets the automation emails.
        /// </summary>
        IAutomationEmailLogic AutomationEmails { get; }

        /// <summary>
        /// Gets or sets the automations.
        /// </summary>
        IAutomationLogic Automations { get; }

        /// <summary>
        /// Gets or sets the automation subscribers.
        /// </summary>
        IAutomationSubscriberLogic AutomationSubscribers { get; }

        /// <summary>
        /// Gets or sets the campaign folders.
        /// </summary>
        ICampaignFolderLogic CampaignFolders { get; }

        /// <summary>
        /// Gets the clients.
        /// </summary>
        IClientLogic Clients { get; }

        /// <summary>
        /// Gets or sets the e commerce stores.
        /// </summary>
        IECommerceLogic ECommerceStores { get;  }


        /// <summary>
        /// Gets thet logic for e-commerce carts to call mail chimp
        /// </summary>
        IECommerceCartLogic ECommerceCarts { get; }

        /// <summary>
        /// Gets the feedback.
        /// </summary>
        IFeedbackLogic Feedback { get; }

        /// <summary>
        /// Gets the file manager files.
        /// </summary>
        IFileManagerFileLogic FileManagerFiles { get; }

        /// <summary>
        /// Gets the file manager folders.
        /// </summary>
        IFileManagerFolderLogic FileManagerFolders { get; }

        /// <summary>
        /// Gets the growth histories.
        /// </summary>
        IGrowthHistoryLogic GrowthHistories { get; }

        /// <summary>
        /// Gets the interest categories.
        /// </summary>
        IInterestCategoryLogic InterestCategories { get; }

        /// <summary>
        /// Gets or sets the interests.
        /// </summary>
        IInterestLogic Interests { get; }


        /// <summary>
        /// Gets the merge fields.
        /// </summary>
        IMergeFieldLogic MergeFields { get; }

        /// <summary>
        /// Gets or sets the messages.
        /// </summary>
        IMessageLogic Messages { get; }

        /// <summary>
        /// Gets or sets the reports.
        /// </summary>
        IReportLogic Reports { get; }

        /// <summary>
        /// Gets the segments.
        /// </summary>
        IListSegmentLogic ListSegments { get; }

        /// <summary>
        /// Gets or sets the template folders.
        /// </summary>
        ITemplateFolderLogic TemplateFolders { get; }

        /// <summary>
        /// Gets or sets the templates.
        /// </summary>
        ITemplateLogic Templates { get; }

        /// <summary>
        /// Gets the logic to access mail chimp web hooks
        /// </summary>
        IWebHookLogic WebHooks { get;  }

        /// <summary>
        /// Gets othe batch logic layer to talk to Mail Chimp
        /// </summary>
        IBatchLogic Batches { get; }
    }
}