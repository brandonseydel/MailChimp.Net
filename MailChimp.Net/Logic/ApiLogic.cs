using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;
using MailChimp.Net.Responses;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace MailChimp.Net.Logic
{
    internal class ApiLogic : BaseLogic, IApiLogic
    {
        public ApiLogic(string apiKey): base(apiKey){}
        
        public async Task<ApiInfo> GetInfo()
        {
            try
            {
                using (var client = CreateMailClient(""))
                {
                    var response = await client.GetAsync($"");
                    response.EnsureSuccessStatusCode();

                    return await response.Content.ReadAsAsync<ApiInfo>();
                }
            }
            catch (WebException ex)
            {

                
                using (var sr = new StreamReader(ex.Response.GetResponseStream()))
                {
                   // throw Task.Factory.StartNew<MailChimpException>(() => {});
                }                
            }

            return null;
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
