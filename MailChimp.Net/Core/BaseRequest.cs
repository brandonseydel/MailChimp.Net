using System.Linq;
using System.Reflection;
using System.Text;
using MailChimp.Net.Logic;

namespace MailChimp.Net.Core
{
    public abstract class BaseRequest
    {
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