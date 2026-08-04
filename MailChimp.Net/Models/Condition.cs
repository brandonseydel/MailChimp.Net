// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Condition.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

/// <summary>
/// The condition.
/// </summary>
public class Condition
{
    /// <summary>
    /// Gets or sets the field.
    /// </summary>
    [MailChimpJsonProperty("field")]
    public string Field { get; set; }

    [MailChimpJsonProperty("condition_type")]
    [MailChimpJsonConverter(MailChimpJsonConverterKind.StringEnumDescription)]
    public ConditionType Type { get; set; }

    [MailChimpJsonProperty("op")]
    [MailChimpJsonConverter(MailChimpJsonConverterKind.StringEnumDescription)]
    public Operator Operator { get; set; }

    [MailChimpJsonProperty("extra")]
    public string Extra { get; set; }

    /// <summary>
    /// Gets or sets the value.
    /// </summary>
    [MailChimpJsonProperty("value")]
    public dynamic Value { get; set; }
}