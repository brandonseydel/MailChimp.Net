// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StringEnumDescriptionConverter.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The string enum description converter.
    /// </summary>
    public class StringEnumDescriptionConverter : JsonConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StringEnumDescriptionConverter"/> class.
        /// Initializes a new instance of the <see cref="T:Newtonsoft.Json.Converters.StringEnumConverter"/> class.
        ///
        /// </summary>
        public StringEnumDescriptionConverter()
        {
            AllowIntegerValues = true;
        }

        /// <summary>
        /// Gets or sets a value indicating whether integer values are allowed.
        ///
        /// </summary>
        ///
        /// <value>
        /// <c>true</c> if integers are allowed; otherwise, <c>false</c>.
        /// </value>
        public bool AllowIntegerValues { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether camel case text.
        /// </summary>
        public bool CamelCaseText { get; set; }

        /// <summary>
        /// The can convert.
        /// </summary>
        /// <param name="objectType">
        /// The object type.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public override bool CanConvert(Type objectType)
        {
            return objectType.GetTypeInfo().IsEnum;
        }

        /// <summary>
        /// The read json.
        /// </summary>
        /// <param name="reader">
        /// The reader.
        /// </param>
        /// <param name="objectType">
        /// The object type.
        /// </param>
        /// <param name="existingValue">
        /// The existing value.
        /// </param>
        /// <param name="serializer">
        /// The serializer.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            objectType = Nullable.GetUnderlyingType(objectType) ?? objectType;
            var eTypeVal = objectType
                        .GetRuntimeFields().Cast<MemberInfo>()
                        .Union(objectType.GetRuntimeProperties())
                        .Where(x => x.GetCustomAttributes(typeof(DescriptionAttribute)).Any())
                        .FirstOrDefault(x => ((DescriptionAttribute)x.GetCustomAttribute(typeof(DescriptionAttribute))).Description == (string)reader.Value);

            return Enum.Parse(objectType, eTypeVal?.Name ?? reader.Value.ToString());
        }

        /// <summary>
        /// Writes the JSON representation of the object.
        ///
        /// </summary>
        /// <param name="writer">
        /// The <see cref="T:Newtonsoft.Json.JsonWriter"/> to write to.
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <param name="serializer">
        /// The calling serializer.
        /// </param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }

            var type = value.GetType();
            var name = Enum.GetName(type, value);
            if (string.IsNullOrWhiteSpace(name)) {
                writer.WriteNull();
                return;
            }

            var description = type.GetRuntimeField(name)
                                  //.GetField(name) // I prefer to get attributes this way
                                  .GetCustomAttributes(false)
                                  .OfType<DescriptionAttribute>()
                                  .Select(x => x.Description)
                                  .SingleOrDefault();

            writer.WriteValue(description ?? name);
        }
    }
}