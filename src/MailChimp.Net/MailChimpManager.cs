using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailChimp.Net.Models;

namespace MailChimp.Net
{
    public class MailChimpManager
    {
        private readonly string _apiKey;

        public MailChimpManager(string apiKey)
        {
            _apiKey = apiKey;
        }

        public List GetLists()
        {

        }

        public async Task<List> GetListsAsync()
        {

        }


    }
}
