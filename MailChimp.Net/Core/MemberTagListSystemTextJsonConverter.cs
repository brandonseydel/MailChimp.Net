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
        => throw new NotImplementedException();

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
