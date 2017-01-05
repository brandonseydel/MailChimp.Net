## MailChimp.Net - A Mail Chimp 3.0 Wrapper

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
