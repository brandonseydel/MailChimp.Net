using System.ComponentModel;

namespace MailChimp.Net.Models;

/// <summary>
/// The type of chimp chatter activity
/// </summary>
public enum ChimpChatterType
{
    [Description("lists:new-subscriber")]
    NewSubscriber,
    [Description("lists:unsubscribes")]
    Unsunscribes,
    [Description("lists:profile-updates")]
    ProfileUpdates,
    [Description("campaigns:facebook-likes")]
    FacebookLikes,
    [Description("campaigns:forward-to-friend")]
    ForwardToFriend,
    [Description("lists:imports")]
    Imports

}