// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MailChimpManager.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

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
        public IMailChimpManager Configure(IMailChimpConfiguration config)
        {
            typeof(MailChimpManager).GetProperties().Select(x => x.GetValue(this)).OfType<BaseLogic>().ToList().ForEach(x => x._mailChimpConfiguration = config);
            return this;
        }

        public static IMailChimpManager Create(IMailChimpConfiguration config)
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
        public MailChimpManager(string apiKey) : this(new MailChimpConfiguration { ApiKey = apiKey })
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MailChimpManager"/> class.
        /// </summary>
        public MailChimpManager() : this(new MailChimpConfiguration())
        {
           
        }

        public MailChimpManager(IMailChimpConfiguration mailChimpConfiguration) : base(mailChimpConfiguration)
        {
            this.Activities = new ActivityLogic(_mailChimpConfiguration);
            this.AbuseReports = new AbuseReportLogic(_mailChimpConfiguration);
            this.Api = new ApiLogic(_mailChimpConfiguration);
            this.Apps = new AuthorizedAppLogic(_mailChimpConfiguration);
            this.AutomationEmails = new AutomationEmailLogic(_mailChimpConfiguration);
            this.AutomationEmailQueues = new AutomationEmailQueueLogic(_mailChimpConfiguration);
            this.Automations = new AutomationLogic(_mailChimpConfiguration);
            this.AutomationSubscribers = new AutomationSubscriberLogic(_mailChimpConfiguration);
            this.Batches = new BatchLogic(_mailChimpConfiguration);
            this.Campaigns = new CampaignLogic(_mailChimpConfiguration);
            this.CampaignFolders = new CampaignFolderLogic(_mailChimpConfiguration);
            this.Clients = new ClientLogic(_mailChimpConfiguration);
            this.Content = new ContentLogic(_mailChimpConfiguration);
            this.Conversations = new ConversationLogic(_mailChimpConfiguration);
            this.ECommerceStores = new ECommerceLogic(_mailChimpConfiguration);
            this.Feedback = new FeedBackLogic(_mailChimpConfiguration);
            this.FileManagerFiles = new FileManagerFileLogic(_mailChimpConfiguration);
            this.FileManagerFolders = new FileManagerFolderLogic(_mailChimpConfiguration);
            this.GrowthHistories = new GrowthHistoryLogic(_mailChimpConfiguration);
            this.InterestCategories = new InterestCategoryLogic(_mailChimpConfiguration);
            this.Interests = new InterestLogic(_mailChimpConfiguration);
            this.Lists = new ListLogic(_mailChimpConfiguration);
            this.ListSegments = new ListSegmentLogic(_mailChimpConfiguration);
            this.Members = new MemberLogic(_mailChimpConfiguration);
            this.MergeFields = new MergeFieldLogic(_mailChimpConfiguration);
            this.Messages = new MessageLogic(_mailChimpConfiguration);
            this.Notes = new NoteLogic(_mailChimpConfiguration);
            this.Reports = new ReportLogic(_mailChimpConfiguration);
            this.TemplateFolders = new TemplateFolderLogic(_mailChimpConfiguration);
            this.Templates = new TemplateLogic(_mailChimpConfiguration);
            this.WebHooks = new WebHookLogic(_mailChimpConfiguration);
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