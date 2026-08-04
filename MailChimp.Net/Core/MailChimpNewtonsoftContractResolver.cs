// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MailChimpNewtonsoftContractResolver.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

#if !NET10_0_OR_GREATER
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MailChimp.Net.Core;

/// <summary>
/// Applies <see cref="MailChimpJsonPropertyAttribute"/> and <see cref="MailChimpJsonConverterAttribute"/>
/// to Newtonsoft.Json contracts on legacy TFMs.
/// </summary>
internal sealed class MailChimpNewtonsoftContractResolver : DefaultContractResolver
{
    protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
    {
        var property = base.CreateProperty(member, memberSerialization);

        if (member.GetCustomAttribute<MailChimpJsonIgnoreAttribute>() != null)
        {
            property.Ignored = true;
            return property;
        }

        var nameAttr = member.GetCustomAttribute<MailChimpJsonPropertyAttribute>();
        if (!string.IsNullOrEmpty(nameAttr?.Name))
        {
            property.PropertyName = nameAttr.Name;
        }

        var converterAttr = member.GetCustomAttribute<MailChimpJsonConverterAttribute>();
        if (converterAttr != null)
        {
            property.Converter = converterAttr.Kind switch
            {
                MailChimpJsonConverterKind.StringEnumDescription => new StringEnumDescriptionConverter(),
                MailChimpJsonConverterKind.MemberTagList => new MemberTagListJsonConverter(),
                _ => property.Converter
            };
        }

        return property;
    }
}
#endif
