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

        public MailChimpManager(string apiKey) : base(apiKey)
        {
            Lists = new ListLogic(ApiKey);
            Api = new ApiLogic(ApiKey);
            Members = new MemberLogic(ApiKey);
            Campaigns = new CampaignLogic(ApiKey);
            Conversations = new ConversationLogic(ApiKey);
        }

        public MailChimpManager()
        {
            Lists = new ListLogic(ApiKey);
            Members = new MemberLogic(ApiKey);
            Campaigns = new CampaignLogic(ApiKey);
            Api = new ApiLogic(ApiKey);
            Conversations = new ConversationLogic(ApiKey);
        }

    }
}
