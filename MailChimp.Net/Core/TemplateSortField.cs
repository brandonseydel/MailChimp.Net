using System;
using System.ComponentModel;

namespace MailChimp.Net.Core;

/// <summary>
/// Sort order for sort_dir
/// </summary>
[Flags]
public enum TemplateSortField
{
    /// <summary>
    /// The send time.
    /// </summary>
    [Description("date_created")]
    DateCreated = 1,

    /// <summary>
    /// The send time.
    /// </summary>
    [Description("name")]
    Name = 2
}
