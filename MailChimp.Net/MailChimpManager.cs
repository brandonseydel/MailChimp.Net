// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MailChimpManager.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Logic;
using Microsoft.Extensions.Options;

namespace MailChimp.Net
{
    /// <summary>
    /// The mail chimp manager.
    /// </summary>
    public class MailChimpManager : MailManagerBase, IMailChimpManager
    {
        public MailChimpManager(IOptions<MailchimpOptions> optionsAccessor) : base(optionsAccessor)
        {
            var options = optionsAccessor.Value;

            Activities = new ActivityLogic(options);
            AbuseReports = new AbuseReportLogic(options);
            Api = new ApiLogic(options);
            Apps = new AuthorizedAppLogic(options);
            AutomationEmails = new AutomationEmailLogic(options);
            AutomationEmailQueues = new AutomationEmailQueueLogic(options);
            Automations = new AutomationLogic(options);
            AutomationSubscribers = new AutomationSubscriberLogic(options);
            Batches = new BatchLogic(options);
            Campaigns = new CampaignLogic(options);
            CampaignFolders = new CampaignFolderLogic(options);
            Clients = new ClientLogic(options);
            Content = new ContentLogic(options);
            Conversations = new ConversationLogic(options);
            ECommerceStores = new ECommerceLogic(options);
            Feedback = new FeedBackLogic(options);
            FileManagerFiles = new FileManagerFileLogic(options);
            FileManagerFolders = new FileManagerFolderLogic(options);
            GrowthHistories = new GrowthHistoryLogic(options);
            InterestCategories = new InterestCategoryLogic(options);
            Interests = new InterestLogic(options);
            Lists = new ListLogic(options);
            ListSegments = new ListSegmentLogic(options);
            Members = new MemberLogic(options);
            MergeFields = new MergeFieldLogic(options);
            Messages = new MessageLogic(options);
            Notes = new NoteLogic(options);
            Reports = new ReportLogic(options);
            TemplateFolders = new TemplateFolderLogic(options);
            Templates = new TemplateLogic(options);
            WebHooks = new WebHookLogic(options);
        }

        public IMailChimpManager Configure(Action<MailchimpOptions> options)
        {
            options(MailchimpOptions);
            return this;
        }

        /// <summary>
        /// Gets the abuse reports.
        /// </summary>
        public IAbuseReportLogic AbuseReports { get; }

        /// <summary>
        /// Gets the activities.
        /// </summary>
        public IActivityLogic Activities { get; }

        /// <summary>
        /// Gets the api.
        /// </summary>
        public IApiLogic Api { get; }

        /// <summary>
        /// Gets the apps.
        /// </summary>
        public IAuthorizedAppLogic Apps { get; }

        /// <summary>
        /// Gets or sets the automation email queues.
        /// </summary>
        public IAutomationEmailQueueLogic AutomationEmailQueues { get; }

        /// <summary>
        /// Gets or sets the automation emails.
        /// </summary>
        public IAutomationEmailLogic AutomationEmails { get; }

        /// <summary>
        /// Gets or sets the automations.
        /// </summary>
        public IAutomationLogic Automations { get; }

        /// <summary>
        /// Gets or sets the automation subscribers.
        /// </summary>
        public IAutomationSubscriberLogic AutomationSubscribers { get; }

        /// <summary>
        /// Gets othe batch logic layer to talk to Mail Chimp
        /// </summary>
        public IBatchLogic Batches { get; }

        /// <summary>
        /// Gets or sets the campaign folders.
        /// </summary>
        public ICampaignFolderLogic CampaignFolders { get; }

        /// <summary>
        /// Gets the campaigns.
        /// </summary>
        public ICampaignLogic Campaigns { get; }

        /// <summary>
        /// Gets the clients.
        /// </summary>
        public IClientLogic Clients { get; }

        /// <summary>
        /// Gets the content.
        /// </summary>
        public IContentLogic Content { get; }

        /// <summary>
        /// Gets the conversations.
        /// </summary>
        public IConversationLogic Conversations { get; }

        /// <summary>
        /// Gets or sets the e commerce stores.
        /// </summary>
        public IECommerceLogic ECommerceStores { get; }

        /// <summary>
        /// Gets the feedback.
        /// </summary>
        public IFeedbackLogic Feedback { get; }

        /// <summary>
        /// Gets the file manager files.
        /// </summary>
        public IFileManagerFileLogic FileManagerFiles { get; }

        /// <summary>
        /// Gets the file manager folders.
        /// </summary>
        public IFileManagerFolderLogic FileManagerFolders { get; }

        /// <summary>
        /// Gets the growth histories.
        /// </summary>
        public IGrowthHistoryLogic GrowthHistories { get; }

        /// <summary>
        /// Gets the interest categories.
        /// </summary>
        public IInterestCategoryLogic InterestCategories { get; }

        /// <summary>
        /// Gets or sets the interests.
        /// </summary>
        public IInterestLogic Interests { get; }

        /// <summary>
        /// Gets the lists.
        /// </summary>
        public IListLogic Lists { get; }

        /// <summary>
        /// Gets the members.
        /// </summary>
        public IMemberLogic Members { get; }

        /// <summary>
        /// Gets the merge fields.
        /// </summary>
        public IMergeFieldLogic MergeFields { get; }

        /// <summary>
        /// Gets or sets the messages.
        /// </summary>
        public IMessageLogic Messages { get; }

        /// <summary>
        /// Gets or sets the notes.
        /// </summary>
        public INoteLogic Notes { get; }

        /// <summary>
        /// Gets or sets the reports.
        /// </summary>
        public IReportLogic Reports { get; }

        /// <summary>
        /// Gets the segments.
        /// </summary>
        public IListSegmentLogic ListSegments { get; }

        /// <summary>
        /// Gets or sets the template folders.
        /// </summary>
        public ITemplateFolderLogic TemplateFolders { get; }

        /// <summary>
        /// Gets or sets the templates.
        /// </summary>
        public ITemplateLogic Templates { get; }

        /// <summary>
        /// Gets the logic to access mail chimp web hooks
        /// </summary>
        public IWebHookLogic WebHooks { get; }

        public int Limit
        {
            get; private set;
        }
    }
}