// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TemplateTest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;
using Xunit;

namespace MailChimp.Net.Tests;

/// <summary>
/// The template test.
/// </summary>
public class TemplateTest : MailChimpTest
{
    TemplateRequest RequestOnlyUserTemplates = new TemplateRequest { Type = "user" };

    /// <summary>
    /// The should_ delete_ all_ user_ templates.
    /// </summary>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    [Fact]
    public async Task Should_Delete_All_User_Templates()
    {
        var allTemplates = await this.MailChimpManager.Templates.GetAllAsync(RequestOnlyUserTemplates).ConfigureAwait(false);
        await Task.WhenAll(allTemplates.Select(x => this.MailChimpManager.Templates.DeleteAsync(x.Id))).ConfigureAwait(false);
        allTemplates = await this.MailChimpManager.Templates.GetAllAsync(RequestOnlyUserTemplates).ConfigureAwait(false);
        Assert.Empty(allTemplates);
    }

    /// <summary>
    /// The should_ delete_ all_ test_ templatefolders.
    /// </summary>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    [Fact]
    public async Task Should_Delete_All_Test_TemplateFolders()
    {
        var allTemplateFolders = await this.MailChimpManager.TemplateFolders.GetAllAsync().ConfigureAwait(false);
        await Task.WhenAll(allTemplateFolders.Where(n => n.Name.StartsWith("TestFolder_")).Select(x => this.MailChimpManager.TemplateFolders.DeleteAsync(x.Id))).ConfigureAwait(false);
        allTemplateFolders = await this.MailChimpManager.TemplateFolders.GetAllAsync().ConfigureAwait(false);
        Assert.Empty(allTemplateFolders.Where(n => n.Name.StartsWith("TestFolder_")));
    }

    /// <summary>
    /// The should_ create_ new_ template.
    /// </summary>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    [Fact]
    public async Task<Template> Should_Create_New_Template()
    {
        //Clear out all the templates
        await this.Should_Delete_All_User_Templates();

        var template = await this.MailChimpManager.Configure((mo) => mo.Limit = 10).Templates.CreateAsync($"Test_{DateTime.UtcNow.Ticks}", null, "<html><body><h1>Test *|FNAME|* </body></html>").ConfigureAwait(false);
        var allTemplates = await this.MailChimpManager.Lists.GetAllAsync().ConfigureAwait(false);
        Assert.True(allTemplates.Any());
        return template;
    }

    /// <summary>
    /// The should_ create_ new_ template.
    /// </summary>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    [Fact]
    public async Task<Template> Should_Create_New_Template_With_FolderId()
    {
        //Clear out all the templates
        await this.Should_Delete_All_User_Templates();
        var templateFolder = await Should_Create_New_TemplateFolder();

        var template = await this.MailChimpManager.Configure((mo) => mo.Limit = 10).Templates.CreateAsync($"Test_{DateTime.UtcNow.Ticks}", templateFolder.Id, "<html><body><h1>Test *|FNAME|* </body></html>").ConfigureAwait(false);
        var allTemplates = await this.MailChimpManager.Templates.GetAllAsync().ConfigureAwait(false);
        Assert.True(allTemplates.Any());
        return template;
    }

    /// <summary>
    /// The should_ create_ new_ templatefolder.
    /// </summary>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    [Fact]
    public async Task<Folder> Should_Create_New_TemplateFolder()
    {
        var templateFolder = await this.MailChimpManager.Configure((mo) => mo.Limit = 10).TemplateFolders.AddAsync($"TestFolder_{DateTime.UtcNow.Ticks}").ConfigureAwait(false);
        Assert.NotNull(templateFolder);
        return templateFolder;
    }

    /// <summary>
    /// The should_ return_ templates.
    /// </summary>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    [Fact]
    public async Task Should_Return_Templates()
    {
        var templates = await this.MailChimpManager.Templates.GetAllAsync(RequestOnlyUserTemplates);
        Assert.NotNull(templates);
    }

    /// <summary>
    /// The should_ return_ templates_ created_ today.
    /// </summary>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    [Fact]
    public async Task Should_Return_Templates_Created_Today()
    {
        var newTemplate = await this.Should_Create_New_Template().ConfigureAwait(false);
        var request = new TemplateRequest()
        {
            BeforeCreatedAt = DateTime.UtcNow,
            SincedCreatedAt = DateTime.UtcNow.AddDays(-1),
            Type = "user"
        };

        var templates = await this.MailChimpManager.Templates.GetAllAsync(request);
        Assert.True(templates.Any());
    }

    /// <summary>
    /// The should_ update_ template.
    /// </summary>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    [Fact]
    public async Task Should_Update_Template()
    {
        var newTemplate = await this.Should_Create_New_Template().ConfigureAwait(false);
        var newName = $"{newTemplate.Name}_V2";
        var updatedTemplate = await this.MailChimpManager.Templates.UpdateAsync(newTemplate.Id, newName, newTemplate.FolderId, "<html><body><h1>Test *|FNAME|* V2</body></html>").ConfigureAwait(false);
        Assert.Equal(newName, updatedTemplate.Name);
    }

    /// <summary>
    /// The should_ return_ one_ template.
    /// </summary>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    [Fact]
    public async Task Should_Return_One_Template()
    {
        var newTemplate = await this.Should_Create_New_Template().ConfigureAwait(false);
        var template = await this.MailChimpManager.Templates.GetAsync(newTemplate.Id).ConfigureAwait(false);
        Assert.NotNull(template);
    }

    /// <summary>
    /// The should_ return_ template_ by_ folderid.
    /// </summary>
    /// <returns>
    /// The <see cref="Task"/>.
    /// </returns>
    [Fact]
    public async Task Should_Return_Template_By_FolderId()
    {
        var template = await this.Should_Create_New_Template_With_FolderId().ConfigureAwait(false);
        Assert.NotNull(template);

        var request = new TemplateRequest()
        {
            FolderId = template.FolderId
        };

        var templates = await this.MailChimpManager.Templates.GetAllAsync(request);
        Assert.True(templates.Any());
    }
}