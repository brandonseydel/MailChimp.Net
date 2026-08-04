// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MailChimpJsonIgnoreAttribute.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace MailChimp.Net.Core;

/// <summary>
/// Excludes a property from JSON serialization for both Newtonsoft (legacy TFMs)
/// and System.Text.Json (net10.0+).
/// </summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public sealed class MailChimpJsonIgnoreAttribute : Attribute
{
}
