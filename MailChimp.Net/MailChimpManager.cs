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

        public IMailChimpManager Configure(Action<MailChimpOptions> options)
        {
            
            options(MailChimpOptions);
            return this;
        }

        public MailChimpManager(string apiKey) : base(apiKey) {
            // The base implementation already sets the mail chimp options
            this.Activities = new ActivityLogic(MailChimpOptions);
            this.AbuseReports = new AbuseReportLogic(MailChimpOptions);
            this.Api = new ApiLogic(MailChimpOptions);
            this.Apps = new AuthorizedAppLogic(MailChimpOptions);
            this.AutomationEmails = new AutomationEmailLogic(MailChimpOptions);
            this.AutomationEmailQueues = new AutomationEmailQueueLogic(MailChimpOptions);
            this.Automations = new AutomationLogic(MailChimpOptions);
            this.AutomationSubscribers = new AutomationSubscriberLogic(MailChimpOptions);
            this.Batches = new BatchLogic(MailChimpOptions);
            this.Campaigns = new CampaignLogic(MailChimpOptions);
            this.CampaignFolders = new CampaignFolderLogic(MailChimpOptions);
            this.Clients = new ClientLogic(MailChimpOptions);
            this.Content = new ContentLogic(MailChimpOptions);
            this.Conversations = new ConversationLogic(MailChimpOptions);
            this.ECommerceStores = new ECommerceLogic(MailChimpOptions);
            this.Feedback = new FeedBackLogic(MailChimpOptions);
            this.FileManagerFiles = new FileManagerFileLogic(MailChimpOptions);
            this.FileManagerFolders = new FileManagerFolderLogic(MailChimpOptions);
            this.GrowthHistories = new GrowthHistoryLogic(MailChimpOptions);
            this.InterestCategories = new InterestCategoryLogic(MailChimpOptions);
            this.Interests = new InterestLogic(MailChimpOptions);
            this.Lists = new ListLogic(MailChimpOptions);
            this.ListSegments = new ListSegmentLogic(MailChimpOptions);
            this.Members = new MemberLogic(MailChimpOptions);
            this.MergeFields = new MergeFieldLogic(MailChimpOptions);
            this.Messages = new MessageLogic(MailChimpOptions);
            this.Notes = new NoteLogic(MailChimpOptions);
            this.Reports = new ReportLogic(MailChimpOptions);
            this.TemplateFolders = new TemplateFolderLogic(MailChimpOptions);
            this.Templates = new TemplateLogic(MailChimpOptions);
            this.WebHooks = new WebHookLogic(MailChimpOptions);
            this.BatchWebHooks = new BatchWebHookLogic(MailChimpOptions);
        }
        
        public MailChimpManager(IOptions<MailChimpOptions> optionsAccessor) : base(optionsAccessor)
        {
            // The base implementation already sets the mail chimp options
            this.Activities = new ActivityLogic(MailChimpOptions);
            this.AbuseReports = new AbuseReportLogic(MailChimpOptions);
            this.Api = new ApiLogic(MailChimpOptions);
            this.Apps = new AuthorizedAppLogic(MailChimpOptions);
            this.AutomationEmails = new AutomationEmailLogic(MailChimpOptions);
            this.AutomationEmailQueues = new AutomationEmailQueueLogic(MailChimpOptions);
            this.Automations = new AutomationLogic(MailChimpOptions);
            this.AutomationSubscribers = new AutomationSubscriberLogic(MailChimpOptions);
            this.Batches = new BatchLogic(MailChimpOptions);
            this.Campaigns = new CampaignLogic(MailChimpOptions);
            this.CampaignFolders = new CampaignFolderLogic(MailChimpOptions);
            this.Clients = new ClientLogic(MailChimpOptions);
            this.Content = new ContentLogic(MailChimpOptions);
            this.Conversations = new ConversationLogic(MailChimpOptions);
            this.ECommerceStores = new ECommerceLogic(MailChimpOptions);
            this.Feedback = new FeedBackLogic(MailChimpOptions);
            this.FileManagerFiles = new FileManagerFileLogic(MailChimpOptions);
            this.FileManagerFolders = new FileManagerFolderLogic(MailChimpOptions);
            this.GrowthHistories = new GrowthHistoryLogic(MailChimpOptions);
            this.InterestCategories = new InterestCategoryLogic(MailChimpOptions);
            this.Interests = new InterestLogic(MailChimpOptions);
            this.Lists = new ListLogic(MailChimpOptions);
            this.ListSegments = new ListSegmentLogic(MailChimpOptions);
            this.Members = new MemberLogic(MailChimpOptions);
            this.MergeFields = new MergeFieldLogic(MailChimpOptions);
            this.Messages = new MessageLogic(MailChimpOptions);
            this.Notes = new NoteLogic(MailChimpOptions);
            this.Reports = new ReportLogic(MailChimpOptions);
            this.TemplateFolders = new TemplateFolderLogic(MailChimpOptions);
            this.Templates = new TemplateLogic(MailChimpOptions);
            this.WebHooks = new WebHookLogic(MailChimpOptions);
            this.BatchWebHooks = new BatchWebHookLogic(MailChimpOptions);
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


        public IBatchWebHookLogic BatchWebHooks { get; }

        public int Limit
        {
            get; private set;
        }
    }
}