using System;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;
using System.Net;
using System.IO;

namespace MailChimp.Net.Logic
{
    internal class ApiLogic : BaseLogic, IApiLogic
    {
        public ApiLogic(string apiKey) : base(apiKey) { }

        public async Task<ApiInfo> GetInfo()
        {
            using (var client = CreateMailClient(""))
            {
                var response = await client.GetAsync($"");
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsAsync<ApiInfo>();
            }

        }

    }

    public class MailChimpException : Exception
    {
        public string Type { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }
        public string Detail { get; set; }
        public string Instance { get; set; }
    }
}
