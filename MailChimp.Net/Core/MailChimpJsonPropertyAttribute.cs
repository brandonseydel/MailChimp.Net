// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MailChimpJsonPropertyAttribute.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace MailChimp.Net.Core;

/// <summary>
/// Maps a CLR property to a Mailchimp JSON field name for both Newtonsoft (legacy TFMs)
/// and System.Text.Json (net10.0+).
/// </summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public sealed class MailChimpJsonPropertyAttribute : Attribute
{
    public MailChimpJsonPropertyAttribute(string name)
    {
        Name = name;
    }

    public string Name { get; }
}
