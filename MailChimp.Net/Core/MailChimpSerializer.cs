// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MailChimpSerializer.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.IO;
#if NET10_0_OR_GREATER
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
#else
using Newtonsoft.Json;
#endif

namespace MailChimp.Net.Core;

/// <summary>
/// Framework-specific JSON serialize/deserialize helpers.
/// Legacy TFMs use Newtonsoft.Json; net10.0+ uses System.Text.Json.
/// Both honor <see cref="MailChimpJsonPropertyAttribute"/> / <see cref="MailChimpJsonConverterAttribute"/>.
/// </summary>
internal static class MailChimpSerializer
{
#if NET10_0_OR_GREATER
    private static readonly JsonSerializerOptions Options = CreateOptions();

    private static JsonSerializerOptions CreateOptions()
    {
        var options = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            PropertyNameCaseInsensitive = true,
            TypeInfoResolver = new DefaultJsonTypeInfoResolver
            {
                Modifiers = { MailChimpJsonContract.ApplyMailChimpAttributes }
            }
        };
        return options;
    }

    public static string Serialize<T>(T value) => JsonSerializer.Serialize(value, Options);

    public static T Deserialize<T>(string json) => JsonSerializer.Deserialize<T>(json, Options);

    public static T Deserialize<T>(Stream stream) => JsonSerializer.Deserialize<T>(stream, Options);
#else
    private static readonly JsonSerializerSettings DefaultSettings = new()
    {
        NullValueHandling = NullValueHandling.Ignore,
        ContractResolver = new MailChimpNewtonsoftContractResolver()
    };

    public static string Serialize<T>(T value, JsonSerializerSettings settings = null)
        => JsonConvert.SerializeObject(value, settings ?? DefaultSettings);

    public static T Deserialize<T>(string json) => JsonConvert.DeserializeObject<T>(json, DefaultSettings);

    public static T Deserialize<T>(Stream stream)
    {
        using var reader = new StreamReader(stream);
        using var jsonReader = new JsonTextReader(reader);
        var jsonSerializer = JsonSerializer.Create(DefaultSettings);
        return jsonSerializer.Deserialize<T>(jsonReader);
    }

    public static JsonSerializerSettings DefaultJsonSettings => DefaultSettings;
#endif
}
