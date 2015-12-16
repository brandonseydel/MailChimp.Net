using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{

    public class StringEnumDescriptionConverter : JsonConverter
    {
        public bool CamelCaseText { get; set; }

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
        /// Initializes a new instance of the <see cref="T:Newtonsoft.Json.Converters.StringEnumConverter"/> class.
        /// 
        /// </summary>
        public StringEnumDescriptionConverter()
        {
            this.AllowIntegerValues = true;
        }

        /// <summary>
        /// Writes the JSON representation of the object.
        /// 
        /// </summary>
        /// <param name="writer">The <see cref="T:Newtonsoft.Json.JsonWriter"/> to write to.</param><param name="value">The value.</param><param name="serializer">The calling serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                var type = value.GetType();
                var name = Enum.GetName(type, value);
                var description = type.GetField(name) // I prefer to get attributes this way
                    .GetCustomAttributes(false)
                    .OfType<DescriptionAttribute>()
                    .Select(x => x.Description)
                    .SingleOrDefault();
                writer.WriteValue(description);
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var eTypeVal = objectType.GetMembers()
                        .Where(x => x.GetCustomAttributes(typeof(DescriptionAttribute)).Any())
                        .FirstOrDefault(x => ((DescriptionAttribute)x.GetCustomAttribute(typeof(DescriptionAttribute))).Description == (string)reader.Value);

            if (eTypeVal == null) return Enum.Parse(objectType, (string)reader.Value);

            return Enum.Parse(objectType, eTypeVal.Name);
        }

        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }
    }
}