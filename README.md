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
Progress on full implementation

- API **100%**
- Authorized Apps **100%**
- Automations **100%**
- Batch Operations **100%**
- Campaigns **100%**
- Campaign Content **100%**
- Campaing Feedback **100%**
- Campaign Folders **100%**
- Campaing Send Checklist **100%**
- Conversations **100%**
- Conversations Messages **100%**
- ECommerce Stores **100%**
- File Manager Files **100%**
- File Manager Folders **100%**
- Lists **100%**
- List Abuse Reports **100%**
- List Activity **100%**
- List Clients **100%**
- List Growth History **100%**
- List Interest Categories **100%**
- List Members **100%**
- List Segments **100%**
- List Web Hooks **100%**
- Template Folders **100%**
- Templates **100%**
- Template Default Content **100%**
- Reports **100%**
- Report Click Reports **100%**
- Report Domain Performance **100%**
- Report EepURL Reports **100%**
- Report Email Activity **100%**
- Report Location **100%**
- Report Sent To **100%**
- Report Sub-Reports **100%**
- Report Unsubscribes **100%**
- ECommerce Carts **100%**
- ECommerce Customers **100%**
- ECommerce Orders **100%**
- ECommerce Order Lines **100%**
- ECommerce Products **100%**
- ECommerce Product Variants **100%**


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
