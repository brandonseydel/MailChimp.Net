// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MailChimpJsonConverterAttribute.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace MailChimp.Net.Core;

/// <summary>
/// Selects a framework-specific JSON converter for a property.
/// </summary>
public enum MailChimpJsonConverterKind
{
    StringEnumDescription,
    MemberTagList
}

/// <summary>
/// Marks a property for conversion via <see cref="MailChimpJsonConverterKind"/>.
/// Legacy TFMs use Newtonsoft converters; net10.0+ uses System.Text.Json converters.
/// </summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public sealed class MailChimpJsonConverterAttribute : Attribute
{
    public MailChimpJsonConverterAttribute(MailChimpJsonConverterKind kind)
    {
        Kind = kind;
    }

    public MailChimpJsonConverterKind Kind { get; }
}
