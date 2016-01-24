using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Logic;

namespace MailChimp.Net
{
    public class MailChimpManager : MailManagerBase, IMailChimpManager
    {
        public MailChimpManager(string apiKey) : base(apiKey)
        {
            Activities = new ActivityLogic(ApiKey);
            AbuseReports = new AbuseReportLogic(ApiKey);
            Api = new ApiLogic(ApiKey);
            Apps = new AuthorizedAppLogic(ApiKey);
            AutomationEmails = new AutomationEmailLogic(ApiKey);
            AutomationEmailQueues = new AutomationEmailQueueLogic(ApiKey);
            Automations = new AutomationLogic(ApiKey);
            AutomationSubscribers = new AutomationSubscriberLogic(ApiKey);
            Campaigns = new CampaignLogic(ApiKey);
            Clients = new ClientLogic(ApiKey);
            Content = new ContentLogic(ApiKey);
            Conversations = new ConversationLogic(ApiKey);
            Feedback = new FeedBackLogic(ApiKey);
            GrowthHistories = new GrowthHistoryLogic(ApiKey);
            InterestCategories = new InterestCategoryLogic(ApiKey);
            Interests = new InterestLogic(ApiKey);
            Lists = new ListLogic(ApiKey);
            Members = new MemberLogic(ApiKey);
            Messages = new MessageLogic(ApiKey);
            Notes = new NoteLogic(ApiKey);
            Reports = new ReportLogic(ApiKey);
            TemplateFolders = new TemplateFolderLogic(ApiKey);
            Templates = new TemplateLogic(ApiKey);
        }

        public INoteLogic Notes { get; set; }

        public IInterestLogic Interests { get; set; }


        public MailChimpManager()
        {
            Activities = new ActivityLogic(ApiKey);
            AbuseReports = new AbuseReportLogic(ApiKey);
            Api = new ApiLogic(ApiKey);
            Apps = new AuthorizedAppLogic(ApiKey);
            AutomationEmails = new AutomationEmailLogic(ApiKey);
            AutomationEmailQueues = new AutomationEmailQueueLogic(ApiKey);
            Automations = new AutomationLogic(ApiKey);
            AutomationSubscribers = new AutomationSubscriberLogic(ApiKey);
            Campaigns = new CampaignLogic(ApiKey);
            Clients = new ClientLogic(ApiKey);
            Content = new ContentLogic(ApiKey);
            Conversations = new ConversationLogic(ApiKey);
            Feedback = new FeedBackLogic(ApiKey);
            GrowthHistories = new GrowthHistoryLogic(ApiKey);
            InterestCategories = new InterestCategoryLogic(ApiKey);
            Interests = new InterestLogic(ApiKey);
            Lists = new ListLogic(ApiKey);
            Members = new MemberLogic(ApiKey);
            Messages = new MessageLogic(ApiKey);
            Notes = new NoteLogic(ApiKey);
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
        public IActivityLogic Activities { get; }
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