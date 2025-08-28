
using System;
using System.ComponentModel;

namespace MailChimp.Net.Core;

/// <summary>
/// Member sort field.
/// </summary>
[Flags]
public enum MemberSortField
{
    [Description("timestamp_opt")]
    TimeStamp = 1,

    [Description("timestamp_signup")]
    TimestampSignup = 2,

    [Description("last_changed")]
    LastChanged = 4
}