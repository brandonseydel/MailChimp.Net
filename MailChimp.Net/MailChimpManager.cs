using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Logic;

namespace MailChimp.Net
{
    public class MailChimpManager : MailManagerBase, IMailChimpManager
    {
        public MailChimpManager(string apiKey) : base(apiKey)
        {
            Api = new ApiLogic(ApiKey);
            Apps = new AuthorizedAppLogic(ApiKey);
            AutomationEmails = new AutomationEmailLogic(ApiKey);
            AutomationEmailQueues = new AutomationEmailQueueLogic(ApiKey);
            Automations = new AutomationLogic(ApiKey);
            AutomationSubscribers = new AutomationSubscriberLogic(ApiKey);
            Campaigns = new CampaignLogic(ApiKey);
            Content = new ContentLogic(ApiKey);
            Conversations = new ConversationLogic(ApiKey);
            Feedback = new FeedBackLogic(ApiKey);
            Lists = new ListLogic(ApiKey);
            Members = new MemberLogic(ApiKey);
            Messages = new MessageLogic(ApiKey);
            Reports = new ReportLogic(ApiKey);
            TemplateFolders = new TemplateFolderLogic(ApiKey);
            Templates = new TemplateLogic(ApiKey);
        }

        public MailChimpManager()
        {
            Api = new ApiLogic(ApiKey);
            Apps = new AuthorizedAppLogic(ApiKey);
            AutomationEmails = new AutomationEmailLogic(ApiKey);
            AutomationEmailQueues = new AutomationEmailQueueLogic(ApiKey);
            Automations = new AutomationLogic(ApiKey);
            AutomationSubscribers = new AutomationSubscriberLogic(ApiKey);
            Campaigns = new CampaignLogic(ApiKey);
            Content = new ContentLogic(ApiKey);
            Conversations = new ConversationLogic(ApiKey);
            Feedback = new FeedBackLogic(ApiKey);
            Lists = new ListLogic(ApiKey);
            Members = new MemberLogic(ApiKey);
            Messages = new MessageLogic(ApiKey);
            Reports = new ReportLogic(ApiKey);
            TemplateFolders = new TemplateFolderLogic(ApiKey);
            Templates = new TemplateLogic(ApiKey);
        }

        public IReportLogic Reports { get; set; }
        public IMessageLogic Messages { get; set; }
        public IAutomationEmailLogic AutomationEmails { get; set; }
        public IAutomationEmailQueueLogic AutomationEmailQueues { get; set; }
        public IAutomationLogic Automations { get; set; }
        public IAutomationSubscriberLogic AutomationSubscribers { get; set; }
        public IClientLogic Clients { get; }
        public IAbuseReportLogic AbuseReports { get; }
        public IListActivityLogic Activities { get; }
        public IFeedbackLogic Feedback { get; }
        public IGrowthHistoryLogic GrowthHistories { get; }
        public IInterestCategoryLogic InterestCategories { get; }
        public ISegmentLogic Segments { get; }
        public IMergeFieldLogic MergeFields { get; }
        public ISendChecklist SendChecklists { get; }
        public IListLogic Lists { get; }
        public IMemberLogic Members { get; }
        public IApiLogic Api { get; }
        public ICampaignLogic Campaigns { get; }
        public IConversationLogic Conversations { get; }
        public IContentLogic Content { get; }
        public IAuthorizedAppLogic Apps { get; }
        public ITemplateLogic Templates { get; set; }
        public ITemplateFolderLogic TemplateFolders { get; set; }
    }
}