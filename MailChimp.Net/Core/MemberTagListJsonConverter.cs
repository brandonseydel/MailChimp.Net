using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core;

/// <summary>
/// This Converter is used to serialize MemberTag lists to the appropriate form
/// for PUT/POST requests. In these request, MailChimp requires just a simple array of tag names.
/// </summary>
public class MemberTagListJsonConverter : JsonConverter
{
    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        var memberTags = (List<MemberTag>)value;

        writer.WriteStartArray();
        foreach (var tag in memberTags)
        {
            writer.WriteToken(JsonToken.String, tag.Name);
        }
        writer.WriteEndArray();
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        throw new NotImplementedException();
    }

    public override bool CanConvert(Type objectType)
    {
        return objectType == typeof(List<MemberTag>);
    }

    public override bool CanRead => false;
}
