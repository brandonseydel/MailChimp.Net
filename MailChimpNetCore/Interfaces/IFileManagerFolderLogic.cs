// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFileManagerFolderLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    /// <summary>
    /// The FileManagerFolderLogic interface.
    /// </summary>
    public interface IFileManagerFolderLogic
    {
        Task<FileManagerFolder> AddAsync(string name);
        Task<IEnumerable<FileManagerFolder>> GetAllAsync(FileManagerRequest request = null);
        Task<FileManagerFolderResponse> GetResponseAsync(FileManagerRequest request = null);
        Task<FileManagerFolder> GetAsync(string folderId, BaseRequest request = null);
        Task DeleteAsync(string folderId);
        Task<FileManagerFolder> UpdateAsync(string name, string folderId);
    }
}