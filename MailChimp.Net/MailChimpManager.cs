using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Logic;

namespace MailChimp.Net
{
    public class MailChimpManager : MailManagerBase, IMailChimpManager
    {
        public  IListLogic Lists { get; }
        public  IMemberLogic Members { get; }
        public  IApiLogic Api { get; }
        public  ICampaignLogic Campaigns { get; }
        public  IConversationLogic Conversations { get; }
        public  IContentLogic Content { get; }
        public IAuthorizedAppLogic Apps { get; }

        public  IClientLogic Clients { get; }
        public IAbuseReportLogic AbuseReports { get; }
        public IActivityLogic Activities { get; }
        public IFeedbackLogic Feedback { get; }
        public IGrowthHistoryLogic GrowthHistories { get; }
        public IInterestCategoryLogic InterestCategories { get; }
        public ISegmentLogic Segments { get; }
        public IMergeFieldLogic MergeFields { get; }
        public ISendChecklist SendChecklists { get; }
        




        public MailChimpManager(string apiKey) : base(apiKey)
        {
            Lists = new ListLogic(ApiKey);
            Api = new ApiLogic(ApiKey);
            Members = new MemberLogic(ApiKey);
            Campaigns = new CampaignLogic(ApiKey);
            Conversations = new ConversationLogic(ApiKey);
            Content = new ContentLogic(ApiKey);
            Apps = new AuthorizedAppLogic(ApiKey);
        }

        public MailChimpManager()
        {
            Lists = new ListLogic(ApiKey);
            Members = new MemberLogic(ApiKey);
            Campaigns = new CampaignLogic(ApiKey);
            Api = new ApiLogic(ApiKey);
            Conversations = new ConversationLogic(ApiKey);
            Content = new ContentLogic(ApiKey);
            Apps = new AuthorizedAppLogic(ApiKey);
        }

    }
}
