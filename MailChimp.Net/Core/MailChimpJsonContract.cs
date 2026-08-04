// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MailChimpJsonContract.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

#if NET10_0_OR_GREATER
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json.Serialization.Metadata;

namespace MailChimp.Net.Core;

/// <summary>
/// Applies <see cref="MailChimpJsonPropertyAttribute"/> and <see cref="MailChimpJsonConverterAttribute"/>
/// to System.Text.Json contracts on net10.0+.
/// </summary>
internal static class MailChimpJsonContract
{
    public static void ApplyMailChimpAttributes(JsonTypeInfo typeInfo)
    {
        if (typeInfo.Kind != JsonTypeInfoKind.Object)
        {
            return;
        }

        // Capture CLR names before any renames.
        var jsonPropertiesByClrName = new Dictionary<string, JsonPropertyInfo>(StringComparer.Ordinal);
        foreach (var jsonProperty in typeInfo.Properties)
        {
            jsonPropertiesByClrName[jsonProperty.Name] = jsonProperty;
        }

        foreach (var property in typeInfo.Type.GetProperties(BindingFlags.Instance | BindingFlags.Public))
        {
            if (property.GetIndexParameters().Length > 0)
            {
                continue;
            }

            if (!jsonPropertiesByClrName.TryGetValue(property.Name, out var jsonPropertyInfo))
            {
                continue;
            }

            if (property.GetCustomAttribute<MailChimpJsonIgnoreAttribute>(inherit: true) != null)
            {
                jsonPropertyInfo.ShouldSerialize = static (_, _) => false;
                continue;
            }

            var nameAttr = property.GetCustomAttribute<MailChimpJsonPropertyAttribute>(inherit: true);
            if (!string.IsNullOrEmpty(nameAttr?.Name))
            {
                jsonPropertyInfo.Name = nameAttr.Name;
            }

            var converterAttr = property.GetCustomAttribute<MailChimpJsonConverterAttribute>(inherit: true);
            if (converterAttr is null)
            {
                continue;
            }

            jsonPropertyInfo.CustomConverter = converterAttr.Kind switch
            {
                MailChimpJsonConverterKind.StringEnumDescription => CreateEnumConverter(property.PropertyType),
                MailChimpJsonConverterKind.MemberTagList => new MemberTagListSystemTextJsonConverter(),
                _ => jsonPropertyInfo.CustomConverter
            };
        }
    }

    private static System.Text.Json.Serialization.JsonConverter CreateEnumConverter(Type propertyType)
    {
        var enumType = Nullable.GetUnderlyingType(propertyType) ?? propertyType;
        var converterType = typeof(StringEnumDescriptionSystemTextJsonConverter<>).MakeGenericType(enumType);
        return (System.Text.Json.Serialization.JsonConverter)Activator.CreateInstance(converterType)!;
    }
}
#endif
