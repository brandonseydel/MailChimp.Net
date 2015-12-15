using System;

namespace MailChimp.Net.Core
{
    public class QueryStringAttribute : Attribute
    {
        public QueryStringAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}