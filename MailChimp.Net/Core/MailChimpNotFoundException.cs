using System;
using System.Net.Http;
using MailChimp.Net.Models;

namespace MailChimp.Net.Core
{
    public class MailChimpNotFoundException : MailChimpException
    {


        public MailChimpNotFoundException(string message, MailChimpApiError error, HttpResponseMessage response) : base(message,error,response)
        {
        }
    }
}
