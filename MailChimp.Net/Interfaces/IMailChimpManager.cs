namespace MailChimp.Net.Interfaces
{
    public interface IMailChimpManager
    {
        IListLogic Lists { get; }
        IMemberLogic Members { get; }
        IApiLogic Api { get; }
        ICampaignLogic Campaigns { get; }
        IConversationLogic Conversations { get; }
        IContentLogic Content { get; }
        IAuthorizedAppLogic Apps { get; }
    }
}