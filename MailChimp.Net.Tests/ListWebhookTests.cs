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

        protected override async Task RunBeforeTestFixture()
        {
            await ClearLists(ListName).ConfigureAwait(false);

            var list = await MailChimpManager.Lists.AddOrUpdateAsync(GetMailChimpList(ListName)).ConfigureAwait(false);
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
                Url = "http://www.google.com"
            };

            // Act
            var response = await MailChimpManager.WebHooks.AddAsync(_listId, webhook).ConfigureAwait(false);
            var existingWebhook = await MailChimpManager.WebHooks.GetAsync(_listId, response.Id).ConfigureAwait(false);

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