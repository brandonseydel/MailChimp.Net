using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// </summary>
    public class ContentTemplate
    {
        /// <summary>
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("sections")]
        public Dictionary<string, object> Sections { get; set; }
    }
}
