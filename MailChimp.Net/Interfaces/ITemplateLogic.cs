using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface ITemplateLogic
    {
        Task<IEnumerable<Template>> GetAllAsync(TemplateRequest request);
        Task<Template> GetAsync(string templateId);
    }
}