using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MailChimp.Net.Core
{
    public class BaseRequest
    {

        [QueryString("fields")]
        public string FieldsToInclude { get; set; }
        [QueryString("exclude_fields")]
        public string FieldsToExclude { get; set; }

        public virtual string ToQueryString()
        {
            var properties = GetType().GetProperties();

            var sb = new StringBuilder();
            sb.Append("?");
            var secondProperty = false;

            properties.ToList().ForEach(prop =>
            {
                var value = prop.GetValue(this);
                var propertyName = prop.GetCustomAttributes<QueryStringAttribute>().Select(x => x.Name).FirstOrDefault();

                if (value == null || propertyName == null) return;

                if (prop.PropertyType.IsEnum)
                {
                    value =
                        prop.GetCustomAttributes<DescriptionAttribute>().Select(x => x.Description).FirstOrDefault() ??
                        value;
                }

                if (secondProperty)
                {
                    sb.Append("&");
                }
                sb.Append($"{propertyName}={value}");
                secondProperty = true;
            });

            return sb.ToString();
        }
    }
}