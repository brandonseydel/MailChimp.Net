using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MailChimp.Net.Core;
using MailChimp.Net.Models;

using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class FileManagerFileResponse : BaseResponse
    {

        public FileManagerFileResponse()
        {
            this.Files = new HashSet<FileManagerFile>();
        }

        [JsonProperty("files")]
        public IEnumerable<FileManagerFile> Files { get; set; }

        [JsonProperty("total_file_size")]
        public int TotalFileSize { get; set; }
    }
}
