## MailChimp.Net - A Mail Chimp 3.0 Wrapper
[![Backers on Open Collective](https://opencollective.com/mailchimp/backers/badge.svg)](#backers)
 [![Sponsors on Open Collective](https://opencollective.com/mailchimp/sponsors/badge.svg)](#sponsors) 



### License
MailChimp.Net is licensed under the [MIT](https://github.com/brandonseydel/MailChimp.Net/blob/master/LICENSE.txt) license.


### Quick Start
Install the [NuGet package](https://www.nuget.org/packages/MailChimp.Net.V3/) from the package manager console:
```powershell
Install-Package MailChimp.Net.V3
```
Using it in code
```CSharp
using MailChimp.Net;
using MailChimp.Net.Interfaces;

IMailChimpManager manager = new MailChimpManager(apiKey); //if you have it in code

<add key="MailChimpApiKey" value="apiKEY" />
IMailChimpManager manager = new MailChimpManager(); //if you have it in config
```

Hint: MailChimp needs at least TLS 1.2. To use this library you have to set TLS 1.2 in ServicePointManager
```
ServicePointManager.SecurityProtocol = ServicePointManager.SecurityProtocol | SecurityProtocolType.Tls12;
```

### Examples

```CSharp
// Instantiate new manager
IMailChimpManager mailChimpManager = new MailChimpManager(apiKey);
```

##### Getting all lists:

```CSharp
var mailChimpListCollection = await this.mailChimpManager.Lists.GetAllAsync().ConfigureAwait(false);
```

##### Getting 50 Lists:

```CSharp
var mailChimpListCollection = await this.mailChimpManager.Lists.GetAllAsync(new ListRequest
                                                               {
                                                                   Limit = 50
                                                               }).ConfigureAwait(false);
```

##### Getting Users from List:

```CSharp
var listId = "TestListId";
await this.mailChimpManager.Members.GetAllAsync(listId).ConfigureAwait(false);
```
##### Adding New User To List

```CSharp
var listId = "TestListId";
// Use the Status property if updating an existing member
var member = new Member { EmailAddress = $"githubTestAccount@test.com", StatusIfNew = Status.Subscribed };
member.MergeFields.Add("FNAME", "HOLY");
member.MergeFields.Add("LNAME", "COW");
await this.mailChimpManager.Members.AddOrUpdateAsync(listId, member);
```

##### Updating An Existing User

```CSharp
// Get reference to existing user if you don't already have it
var listId = "TestListId";
var members = await this.mailChimpManager.Members.GetAllAsync(listId).ConfigureAwait(false);
var member = members.First(x => x.EmailAddress == "abc@def.com");

// Update the user
member.MergeFields.Add("FNAME", "New first name");
member.MergeFields.Add("LNAME", "New last name");
await this.mailChimpManager.Members.AddOrUpdateAsync(listId, member);
```

##### Adding/Removing a Tag From a User

```CSharp
Tags tags = new Tags();
tags.MemberTags.Add(new Tag() { Name = "Awesome Person", Status = "active" });
await this.mailChimpManager.Members.AddTagsAsync(listId, "abc@def.com", tags);
```
To remove the tag, use "inactive" as the Status.

### Status
Full Mailchimp Marketing API coverage (models, interfaces, and logic wired on `IMailChimpManager`).

**Target frameworks:** `net45`, `net472`, `netstandard1.3`, `netstandard2.0`, `net10.0`

| TFM | JSON serializer | Newtonsoft.Json | Microsoft.Extensions.* |
|---|---|---|---|
| `net45` | Newtonsoft.Json 13.0.4 | Yes | — |
| `net472` | Newtonsoft.Json 13.0.4 | Yes | 10.0.10 |
| `netstandard1.3` | Newtonsoft.Json 13.0.4 | Yes | 1.1.2 (last line supporting netstandard1.x) |
| `netstandard2.0` | Newtonsoft.Json 13.0.4 | Yes | 10.0.10 |
| `net10.0` | **System.Text.Json** | **None** | 10.0.10 |

Models use library-local `[MailChimpJsonProperty]` / `[MailChimpJsonConverter]` attributes. Legacy TFMs map those through a Newtonsoft contract resolver; `net10.0` maps them through System.Text.Json type-info modifiers. API JSON shapes stay aligned across TFMs, and `net10.0` has no Newtonsoft dependency at compile time or runtime.

- API / Ping **100%**
- Account Exports **100%**
- Audiences / Contacts (BETA) **100%**
- Authorized Apps **100%**
- Automation flows / Customer Journeys (trigger) **100%**
- Classic Automations (+ create/archive, email update/delete) **100%**
- Batch Operations **100%**
- Batch Webhooks **100%**
- Campaigns (+ search, pause/resume/create-resend) **100%**
- Campaign Content **100%**
- Campaign Feedback **100%**
- Campaign Folders **100%**
- Campaign Send Checklist **100%**
- Connected Sites **100%**
- Conversations **100%** *(obsolete — prefer Mailchimp Inbox)*
- Conversations Messages **100%** *(obsolete — prefer Mailchimp Inbox)*
- E-commerce Stores **100%**
- E-commerce Carts / Customers / Orders / Order Lines **100%**
- E-commerce Products / Variants / Images **100%**
- E-commerce Promo Rules / Codes **100%**
- E-commerce account-level Orders + PUT upserts **100%**
- Facebook Ads **100%**
- File Manager Files / Folders / Files-in-Folder **100%**
- Landing Pages (+ content, publish/unpublish) **100%**
- Lists / Audiences **100%**
- List Abuse Reports / Activity / Clients / Growth History **100%**
- List Interest Categories / Interests **100%**
- List Locations **100%**
- List Members (+ goals, activity feed, tags, events) **100%**
- List Segments / Merge Fields / Signup Forms / Surveys / Webhooks **100%**
- Reporting (landing pages, surveys, facebook ads) **100%**
- Reports (campaign) + ecommerce product activity **100%**
- Search Campaigns / Search Members **100%**
- SMS Campaigns (+ content/actions) **100%**
- Template Folders / Templates / Default Content **100%**
- Verified Domains **100%**

Total **100%**

## Contributors

This project exists thanks to all the people who contribute. [[Contribute](CONTRIBUTING.md)].
<a href="https://github.com/brandonseydel/MailChimp.Net/graphs/contributors"><img src="https://opencollective.com/mailchimp/contributors.svg?width=890&button=false" /></a>


## Backers

Thank you to all our backers! 🙏 [[Become a backer](https://opencollective.com/mailchimp#backer)]

<a href="https://opencollective.com/mailchimp#backers" target="_blank"><img src="https://opencollective.com/mailchimp/backers.svg?width=890"></a>


## Sponsors

Support this project by becoming a sponsor. Your logo will show up here with a link to your website. [[Become a sponsor](https://opencollective.com/mailchimp#sponsor)]

<a href="https://opencollective.com/mailchimp/sponsor/0/website" target="_blank"><img src="https://opencollective.com/mailchimp/sponsor/0/avatar.svg"></a>
<a href="https://opencollective.com/mailchimp/sponsor/1/website" target="_blank"><img src="https://opencollective.com/mailchimp/sponsor/1/avatar.svg"></a>
<a href="https://opencollective.com/mailchimp/sponsor/2/website" target="_blank"><img src="https://opencollective.com/mailchimp/sponsor/2/avatar.svg"></a>
<a href="https://opencollective.com/mailchimp/sponsor/3/website" target="_blank"><img src="https://opencollective.com/mailchimp/sponsor/3/avatar.svg"></a>
<a href="https://opencollective.com/mailchimp/sponsor/4/website" target="_blank"><img src="https://opencollective.com/mailchimp/sponsor/4/avatar.svg"></a>
<a href="https://opencollective.com/mailchimp/sponsor/5/website" target="_blank"><img src="https://opencollective.com/mailchimp/sponsor/5/avatar.svg"></a>
<a href="https://opencollective.com/mailchimp/sponsor/6/website" target="_blank"><img src="https://opencollective.com/mailchimp/sponsor/6/avatar.svg"></a>
<a href="https://opencollective.com/mailchimp/sponsor/7/website" target="_blank"><img src="https://opencollective.com/mailchimp/sponsor/7/avatar.svg"></a>
<a href="https://opencollective.com/mailchimp/sponsor/8/website" target="_blank"><img src="https://opencollective.com/mailchimp/sponsor/8/avatar.svg"></a>
<a href="https://opencollective.com/mailchimp/sponsor/9/website" target="_blank"><img src="https://opencollective.com/mailchimp/sponsor/9/avatar.svg"></a>
