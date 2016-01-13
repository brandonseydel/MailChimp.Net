using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class TemplateFolderResponse : BaseResponse
    {
        public TemplateFolderResponse()
        {
            Folders = new HashSet<Folder>();
        }

        [JsonProperty("folders")]
        public IEnumerable<Folder> Folders { get; set; }
    }

}

