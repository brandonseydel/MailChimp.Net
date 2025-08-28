// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFileManagerFolderLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces;

/// <summary>
/// The FileManagerFolderLogic interface.
/// </summary>
public interface IFileManagerFolderLogic
{
    Task<FileManagerFolder> AddAsync(string name, CancellationToken cancellationToken = default);
    Task<IEnumerable<FileManagerFolder>> GetAllAsync(FileManagerRequest request = null, CancellationToken cancellationToken = default);
    Task<FileManagerFolderResponse> GetResponseAsync(FileManagerRequest request = null, CancellationToken cancellationToken = default);
    Task<FileManagerFolder> GetAsync(string folderId, BaseRequest request = null, CancellationToken cancellationToken = default);
    Task DeleteAsync(string folderId, CancellationToken cancellationToken = default);
    Task<FileManagerFolder> UpdateAsync(string name, string folderId, CancellationToken cancellationToken = default);
}