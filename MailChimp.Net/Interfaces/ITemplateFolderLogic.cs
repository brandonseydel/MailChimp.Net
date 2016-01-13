using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    public interface ITemplateFolderLogic
    {
        Task<Folder> AddAsync(string folderId, string name);
        Task<Folder> DeleteAsync(string folderId);
        Task<IEnumerable<Folder>> GetAllAsync(QueryableBaseRequest request);
        Task<Folder> GetAsync(string folderId, BaseRequest request);
        Task<Folder> UpdateAsync(string folderId, string name);
    }
}