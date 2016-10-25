using System.Threading.Tasks;
using FluentAssertions;
using MailChimp.Net.Core;
using MailChimp.Net.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailChimp.Net.Tests
{
    [TestClass]
    public class ListWebhookTests : MailChimpTest
    {
        private const string ListName = "TestListWebhooks";
        private string _listId = string.Empty;

        internal override async Task RunBeforeTestFixture()
        {
            await ClearLists(ListName);

            var list = await _mailChimpManager.Lists.AddOrUpdateAsync(GetMailChimpList(ListName));
            _listId = list.Id;
        }

        [TestMethod]
        public async Task Should_Create_Webhook()
        {
            // Arrange
            var webhook = new WebHook
            {
                Event = new Event
                {
                    Campaign = true,
                    Cleaned = true,
                    Profile = true,
                    Subscribe = true,
                    Unsubscribe = true,
                    Upemail = true
                },
                Source = new Source
                {
                    Admin = true,
                    Api = true,
                    User = true
                },
                Url = "www.google.com"
            };

            // Act
            var response = await _mailChimpManager.WebHooks.AddAsync(_listId, webhook);
            var existingWebhook = await _mailChimpManager.WebHooks.GetAsync(_listId, response.Id);

            // Assert
            response.Id.Should().NotBeEmpty();
            response.ListId.Should().Be(_listId);
            response.Links.Should().NotBeEmpty();
            response.ShouldBeEquivalentTo(webhook,
                o => o.Excluding(i => i.Id).Excluding(i => i.ListId).Excluding(i => i.Links));

            existingWebhook.Should().NotBeNull();
        }
    }
}