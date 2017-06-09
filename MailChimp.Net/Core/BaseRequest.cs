// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseRequest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
#pragma warning disable 1584,1711,1572,1581,1580

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The base request.
    /// </summary>
    public class BaseRequest
    {
        /// <summary>
        /// Gets or sets the fields to exclude.
        /// </summary>
        [QueryString("exclude_fields")]
        public string FieldsToExclude { get; set; }

        /// <summary>
        /// Gets or sets the fields to include.
        /// </summary>
        [QueryString("fields")]
        public string FieldsToInclude { get; set; }

        /// <summary>
        /// The to query string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
        /// <exception cref="ArgumentNullException"><paramref name="action" /> is null.</exception>
        /// <exception cref="NotSupportedException"><paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception>
        /// <exception cref="TypeLoadException">A custom attribute type cannot be loaded. </exception>
        /// <exception cref="InvalidOperationException">This member belongs to a type that is loaded into the reflection-only context. See How to: Load Assemblies into the Reflection-Only Context.</exception>
        public virtual string ToQueryString()
        {
            var properties = GetType().GetTypeInfo().GetProperties();

            var sb = new StringBuilder();
            sb.Append("?");
            var secondProperty = false;

            properties.ToList().ForEach(
                prop =>
                    {
                        var value = prop.GetValue(this);
                        var propertyName =
                            prop.GetCustomAttributes<QueryStringAttribute>().Select(x => x.Name).FirstOrDefault() ?? prop.Name.ToLower();

                        if (value == null)
                        {
                            return;
                        }
                        var type = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;

                        if (type.GetTypeInfo().IsEnum)
                        {
                            var member = type.GetTypeInfo().GetMember(value.ToString());
                            value =
                                member.FirstOrDefault()?
                                      .GetCustomAttributes(typeof(DescriptionAttribute), false)
                                      .OfType<DescriptionAttribute>()
                                      .FirstOrDefault()?.Description ?? value;
                        }

                        if (secondProperty)
                        {
                            sb.Append("&");
                        }

                        value = value is DateTime ? ((DateTime)value).ToString(@"yyyy-MM-dd HH:mm:ss") :
                                value is IEnumerable && !(value is string) ? string.Join(",", ((IEnumerable) value).Cast<object>()) : 
                                value;

                        //We don't want to add anything if after all this work their is still no data :(
                        if (string.IsNullOrWhiteSpace(value.ToString()))
                        {
                            return;
                        }

                        sb.Append($"{propertyName}={value}");
                        secondProperty = true;
                    });

            return sb.ToString();
        }
    }
}