// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StringEnumDescriptionSystemTextJsonConverter.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

#if NET10_0_OR_GREATER
using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

/// <summary>
/// System.Text.Json converter that reads/writes enum values via <see cref="DescriptionAttribute"/>.
/// </summary>
internal sealed class StringEnumDescriptionSystemTextJsonConverter<TEnum> : JsonConverter<TEnum>
    where TEnum : struct, Enum
{
    public override TEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Number && reader.TryGetInt32(out var intValue))
        {
            return (TEnum)Enum.ToObject(typeof(TEnum), intValue);
        }

        var text = reader.GetString();
        var match = typeof(TEnum)
            .GetRuntimeFields()
            .Cast<MemberInfo>()
            .Union(typeof(TEnum).GetRuntimeProperties())
            .Where(x => x.GetCustomAttributes(typeof(DescriptionAttribute)).Any())
            .FirstOrDefault(x =>
                ((DescriptionAttribute)x.GetCustomAttribute(typeof(DescriptionAttribute)))!.Description == text);

        return (TEnum)Enum.Parse(typeof(TEnum), match?.Name ?? text);
    }

    public override void Write(Utf8JsonWriter writer, TEnum value, JsonSerializerOptions options)
    {
        var name = Enum.GetName(typeof(TEnum), value);
        if (string.IsNullOrWhiteSpace(name))
        {
            writer.WriteNullValue();
            return;
        }

        var description = typeof(TEnum).GetRuntimeField(name)
            ?.GetCustomAttributes(false)
            .OfType<DescriptionAttribute>()
            .Select(x => x.Description)
            .SingleOrDefault();

        writer.WriteStringValue(description ?? name);
    }
}
#endif
