using MailChimp.Net.Core.Responses;
using MailChimp.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Net.Interfaces;

public interface IConnectedWebsiteLogic
{
    Task<IEnumerable<Site>> GetAllAsync();
    Task<Site> AddAsync(string foreignId, string domain);
}