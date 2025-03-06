// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryStringAttribute.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The query string attribute.
    /// </summary>
    public class QueryStringAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryStringAttribute"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        public QueryStringAttribute(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; private set; }
    }
}