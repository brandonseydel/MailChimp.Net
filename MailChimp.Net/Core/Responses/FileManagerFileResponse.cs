using System.Collections.Generic;
using MailChimp.Net.Models;

using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class FileManagerFileResponse : BaseResponse
    {

        public FileManagerFileResponse()
        {
            Files = new HashSet<FileManagerFile>();
        }

        [JsonProperty("files")]
        public IEnumerable<FileManagerFile> Files { get; set; }

        [JsonProperty("total_file_size")]
        public int TotalFileSize { get; set; }
    }
}
