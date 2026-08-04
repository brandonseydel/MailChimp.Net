using System;
using System.Collections.Generic;
using System.Text;
using MailChimp.Net.Core;
namespace MailChimp.Net.Models;

public class Combination
{
    [MailChimpJsonProperty("id")]
    public string Id { get; set; }
}