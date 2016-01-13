using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    public class ReportResponse : BaseResponse
    {
        public ReportResponse()
        {
            Reports = new HashSet<Report>();
        }


        [JsonProperty("reports")]
        public IEnumerable<Report> Reports { get; set; }

    }
}