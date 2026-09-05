// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MemberTagListSystemTextJsonConverter.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

#if NET10_0_OR_GREATER
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using MailChimp.Net.Models;

namespace MailChimp.Net.Core;

/// <summary>
/// System.Text.Json converter that serializes member tags as a simple string array for PUT/POST requests.
/// </summary>
internal sealed class MemberTagListSystemTextJsonConverter : JsonConverter<List<MemberTag>>
{
    public override List<MemberTag> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return null;
        }

        if (reader.TokenType != JsonTokenType.StartArray)
        {
            throw new JsonException($"Unexpected token {reader.TokenType} when reading member tags, expected an array.");
        }

        var tags = new List<MemberTag>();
        while (reader.Read())
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.EndArray:
                    return tags;

                case JsonTokenType.Null:
                    break;

                case JsonTokenType.String:
                    tags.Add(new MemberTag { Name = reader.GetString() });
                    break;

                case JsonTokenType.StartObject:
                    var tag = JsonSerializer.Deserialize<MemberTag>(ref reader, options);
                    if (tag != null)
                    {
                        tags.Add(tag);
                    }

                    break;

                default:
                    throw new JsonException($"Unexpected token {reader.TokenType} when reading a member tag.");
            }
        }

        throw new JsonException("Unexpected end of JSON when reading member tags.");
    }

    public override void Write(Utf8JsonWriter writer, List<MemberTag> value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        if (value != null)
        {
            foreach (var tag in value)
            {
                writer.WriteStringValue(tag?.Name);
            }
        }
        writer.WriteEndArray();
    }
}
#endif
