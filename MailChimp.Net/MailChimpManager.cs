// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MailChimpManager.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Logic;
using System.Linq;

// ReSharper disable CommentTypo
// ReSharper disable IdentifierTypo
namespace MailChimp.Net
{
    /// <summary>
    /// The mail chimp manager.
    /// </summary>
    public class MailChimpManager : MailManagerBase, IMailChimpManager
    {


        /// <summary>
        /// Sets the limit on all GetAllAsync responses with QueryableBaseRequest
        /// </summary>
        /// <param name="limit"></param>
        /// <returns></returns>
        public IMailChimpManager Configure(MailChimpConfiguration config)
        {
            this.Limit = config.Limit == 0 ? MailChimpConfiguration.DefaultLimit : config.Limit;
            this.ApiKey = string.IsNullOrWhiteSpace(config.ApiKey) ? this.ApiKey : config.ApiKey;
            typeof(MailChimpManager).GetProperties().Select(x => x.GetValue(this)).OfType<BaseLogic>().ToList().ForEach(x => x._limit = this.Limit);
            return this;
        }

        public static IMailChimpManager Create(MailChimpConfiguration config)
        {
            var mailChimpManager = (new MailChimpManager()).Configure(config);
            return mailChimpManager;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MailChimpManager"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api key.
        /// </param>
        public MailChimpManager(string apiKey) : base(apiKey)
        {
            this.Activities = new ActivityLogic(ApiKey, Limit);
            this.AbuseReports = new AbuseReportLogic(ApiKey, Limit);
            this.Api = new ApiLogic(ApiKey, Limit);
            this.Apps = new AuthorizedAppLogic(ApiKey, Limit);
            this.AutomationEmails = new AutomationEmailLogic(ApiKey, Limit);
            this.AutomationEmailQueues = new AutomationEmailQueueLogic(ApiKey, Limit);
            this.Automations = new AutomationLogic(ApiKey, Limit);
            this.AutomationSubscribers = new AutomationSubscriberLogic(ApiKey, Limit);
            this.Batches = new BatchLogic(ApiKey, Limit);
            this.Campaigns = new CampaignLogic(ApiKey, Limit);
            this.CampaignFolders = new CampaignFolderLogic(ApiKey, Limit);
            this.Clients = new ClientLogic(ApiKey, Limit);
            this.Content = new ContentLogic(ApiKey, Limit);
            this.Conversations = new ConversationLogic(ApiKey, Limit);
            this.ECommerceStores = new ECommerceLogic(ApiKey, Limit);
            this.Feedback = new FeedBackLogic(ApiKey, Limit);
            this.FileManagerFiles = new FileManagerFileLogic(ApiKey, Limit);
            this.FileManagerFolders = new FileManagerFolderLogic(ApiKey, Limit);
            this.GrowthHistories = new GrowthHistoryLogic(ApiKey, Limit);
            this.InterestCategories = new InterestCategoryLogic(ApiKey, Limit);
            this.Interests = new InterestLogic(ApiKey, Limit);
            this.Lists = new ListLogic(ApiKey, Limit);
            this.ListSegments = new ListSegmentLogic(ApiKey, Limit);
            this.Members = new MemberLogic(ApiKey, Limit);
            this.MergeFields = new MergeFieldLogic(ApiKey, Limit);
            this.Messages = new MessageLogic(ApiKey, Limit);
            this.Notes = new NoteLogic(ApiKey, Limit);
            this.Reports = new ReportLogic(ApiKey, Limit);
            this.TemplateFolders = new TemplateFolderLogic(ApiKey, Limit);
            this.Templates = new TemplateLogic(ApiKey, Limit);
            this.WebHooks = new WebHookLogic(ApiKey, Limit);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MailChimpManager"/> class.
        /// </summary>
        public MailChimpManager()
        {
            this.Activities = new ActivityLogic(ApiKey, Limit);
            this.AbuseReports = new AbuseReportLogic(ApiKey, Limit);
            this.Api = new ApiLogic(ApiKey, Limit);
            this.Apps = new AuthorizedAppLogic(ApiKey, Limit);
            this.AutomationEmails = new AutomationEmailLogic(ApiKey, Limit);
            this.AutomationEmailQueues = new AutomationEmailQueueLogic(ApiKey, Limit);
            this.Automations = new AutomationLogic(ApiKey, Limit);
            this.AutomationSubscribers = new AutomationSubscriberLogic(ApiKey, Limit);
            this.Batches = new BatchLogic(ApiKey, Limit);
            this.Campaigns = new CampaignLogic(ApiKey, Limit);
            this.CampaignFolders = new CampaignFolderLogic(ApiKey, Limit);
            this.Clients = new ClientLogic(ApiKey, Limit);
            this.Content = new ContentLogic(ApiKey, Limit);
            this.Conversations = new ConversationLogic(ApiKey, Limit);
            this.ECommerceStores = new ECommerceLogic(ApiKey, Limit);
            this.Feedback = new FeedBackLogic(ApiKey, Limit);
            this.FileManagerFiles = new FileManagerFileLogic(ApiKey, Limit);
            this.FileManagerFolders = new FileManagerFolderLogic(ApiKey, Limit);
            this.GrowthHistories = new GrowthHistoryLogic(ApiKey, Limit);
            this.InterestCategories = new InterestCategoryLogic(ApiKey, Limit);
            this.Interests = new InterestLogic(ApiKey, Limit);
            this.Lists = new ListLogic(ApiKey, Limit);
            this.ListSegments = new ListSegmentLogic(ApiKey, Limit);
            this.Members = new MemberLogic(ApiKey, Limit);
            this.MergeFields = new MergeFieldLogic(ApiKey, Limit);
            this.Messages = new MessageLogic(ApiKey, Limit);
            this.Notes = new NoteLogic(ApiKey, Limit);
            this.Reports = new ReportLogic(ApiKey, Limit);
            this.TemplateFolders = new TemplateFolderLogic(ApiKey, Limit);
            this.Templates = new TemplateLogic(ApiKey, Limit);
            this.WebHooks = new WebHookLogic(ApiKey, Limit);
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