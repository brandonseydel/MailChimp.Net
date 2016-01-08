using System;
using System.Runtime.Serialization;

namespace MailChimp.Net.Core
{
    public class MailChimpException : Exception
    {
        public MailChimpException(SerializationInfo info, StreamingContext context)
        {
            Detail = info?.GetString("detail");
            Title = info?.GetString("title");
            Type = info?.GetString("type");
            Status = info?.GetInt32("status") ?? 0;
            Instance = info?.GetString("instance");
        }

        public string Type { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }
        public string Detail { get; set; }
        public string Instance { get; set; }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            info?.AddValue("detail", Detail);
            info?.AddValue("title", Title);
            info?.AddValue("type", Type);
            info?.AddValue("status", Status);
            info?.AddValue("instance", Instance);
        }
    }
}