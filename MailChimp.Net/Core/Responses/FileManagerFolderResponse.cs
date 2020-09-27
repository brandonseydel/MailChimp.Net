﻿using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class FileManagerFolderResponse
    {
        public FileManagerFolderResponse()
        {
            Folders = new HashSet<FileManagerFolder>();
            Links = new HashSet<Link>();
        }

        [JsonProperty("folders")]
        public IEnumerable<FileManagerFolder> Folders { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }

        [JsonProperty("_links")]
        public IEnumerable<Link> Links { get; set; }
    }
}
