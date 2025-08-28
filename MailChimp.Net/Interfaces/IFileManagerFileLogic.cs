// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFileManagerFileLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace MailChimp.Net.Interfaces;

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

using Core;
using Models;

/// <summary>
/// The FileManagerFileLogic interface.
/// </summary>
public interface IFileManagerFileLogic
{
    /// <summary>
    /// The add file async.
    /// </summary>
    /// <param name="name">
    /// The name.
    /// </param>
    /// <param name="folderId">
    /// The folder id.
    /// </param>
    /// <param name="fileName">
    /// The file name.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    [Obsolete("This method is deprecated.")]
    Task<FileManagerFile> AddFileAsync(string name, string folderId, string fileName, CancellationToken cancellationToken = default);

    /// <summary>
    /// The add async.
    /// </summary>
    /// <param name="name">
    /// The name.
    /// </param>
    /// <param name="folderId">
    /// The folder id.
    /// </param>
    /// <param name="base64String">
    /// The base 64 string.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    [Obsolete("This method is deprecated.")]
    Task<FileManagerFile> AddAsync(string name, string folderId, string base64String, CancellationToken cancellationToken = default);

    /// <summary>
    /// The add async.
    /// </summary>
    /// <param name="name">
    /// The name.
    /// </param>
    /// <param name="folderId">
    /// The folder id.
    /// </param>
    /// <param name="fileStream">
    /// The file stream.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    [Obsolete("This method is deprecated.")]
    Task<FileManagerFile> AddAsync(string name, string folderId, Stream fileStream, CancellationToken cancellationToken = default);

    /// <summary>
    /// The add file async.
    /// </summary>
    /// <param name="name">
    /// The name.
    /// </param>
    /// <param name="folderId">
    /// The folder id.
    /// </param>
    /// <param name="fileName">
    /// The file name.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    Task<FileManagerFile> AddFileAsync(string name, int folderId, string fileName, CancellationToken cancellationToken = default);

    /// <summary>
    /// The add async.
    /// </summary>
    /// <param name="name">
    /// The name.
    /// </param>
    /// <param name="folderId">
    /// The folder id.
    /// </param>
    /// <param name="base64String">
    /// The base 64 string.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    Task<FileManagerFile> AddAsync(string name, int folderId, string base64String, CancellationToken cancellationToken = default);

    /// <summary>
    /// The add async.
    /// </summary>
    /// <param name="name">
    /// The name.
    /// </param>
    /// <param name="folderId">
    /// The folder id.
    /// </param>
    /// <param name="fileStream">
    /// The file stream.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    Task<FileManagerFile> AddAsync(string name, int folderId, Stream fileStream, CancellationToken cancellationToken = default);



    /// <summary>
    /// The get all async.
    /// </summary>
    /// <param name="request">
    /// The request.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    Task<IEnumerable<FileManagerFile>> GetAllAsync(FileManagerRequest request = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// The get async.
    /// </summary>
    /// <param name="fileId">
    /// The file id.
    /// </param>
    /// <param name="request">
    /// The request.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    Task<FileManagerFile> GetAsync(string fileId, BaseRequest request = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// The delete async.
    /// </summary>
    /// <param name="fileId">
    /// The file id.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    Task DeleteAsync(string fileId, CancellationToken cancellationToken = default);

    /// <summary>
    /// The update file async.
    /// </summary>
    /// <param name="fileId">
    /// The file id.
    /// </param>
    /// <param name="name">
    /// The name.
    /// </param>
    /// <param name="folderId">
    /// The folder id.
    /// </param>
    /// <param name="fileName">
    /// The file name.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    [Obsolete("This method is deprecated.")]
    Task<FileManagerFile> UpdateFileAsync(string fileId, string name, string folderId, string fileName, CancellationToken cancellationToken = default);

    /// <summary>
    /// The update async.
    /// </summary>
    /// <param name="fileId">
    /// The file id.
    /// </param>
    /// <param name="name">
    /// The name.
    /// </param>
    /// <param name="folderId">
    /// The folder id.
    /// </param>
    /// <param name="base64String">
    /// The base 64 string.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    [Obsolete("This method is deprecated.")]
    Task<FileManagerFile> UpdateAsync(string fileId, string name, string folderId, string base64String, CancellationToken cancellationToken = default);

    /// <summary>
    /// The update async.
    /// </summary>
    /// <param name="fileId">
    /// The file id.
    /// </param>
    /// <param name="name">
    /// The name.
    /// </param>
    /// <param name="folderId">
    /// The folder id.
    /// </param>
    /// <param name="stream">
    /// The stream.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    [Obsolete("This method is deprecated.")]
    Task<FileManagerFile> UpdateAsync(string fileId, string name, string folderId, Stream stream, CancellationToken cancellationToken = default);


    /// <summary>
    /// The update file async.
    /// </summary>
    /// <param name="fileId">
    /// The file id.
    /// </param>
    /// <param name="name">
    /// The name.
    /// </param>
    /// <param name="folderId">
    /// The folder id.
    /// </param>
    /// <param name="fileName">
    /// The file name.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    Task<FileManagerFile> UpdateFileAsync(string fileId, string name, int folderId, string fileName, CancellationToken cancellationToken = default);

    /// <summary>
    /// The update async.
    /// </summary>
    /// <param name="fileId">
    /// The file id.
    /// </param>
    /// <param name="name">
    /// The name.
    /// </param>
    /// <param name="folderId">
    /// The folder id.
    /// </param>
    /// <param name="base64String">
    /// The base 64 string.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    Task<FileManagerFile> UpdateAsync(string fileId, string name, int folderId, string base64String, CancellationToken cancellationToken = default);

    /// <summary>
    /// The update async.
    /// </summary>
    /// <param name="fileId">
    /// The file id.
    /// </param>
    /// <param name="name">
    /// The name.
    /// </param>
    /// <param name="folderId">
    /// The folder id.
    /// </param>
    /// <param name="stream">
    /// The stream.
    /// </param>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    Task<FileManagerFile> UpdateAsync(string fileId, string name, int folderId, Stream stream, CancellationToken cancellationToken = default);

    Task<FileManagerFileResponse> GetResponseAsync(FileManagerRequest request = null, CancellationToken cancellationToken = default);
}