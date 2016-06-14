# MailChimp.Net - A Mail Chimp 3.0 Wrapper

### Quick Start
Install the [NuGet package](https://www.nuget.org/packages/MailChimp.Net.V3/) from the package manager console:
```powershell
Install-Package MailChimp.NET
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
await this._mailChimpManager.Members.GetAllAsync(listId).ConfigureAwait(false);
```
##### Adding User To List

```CSharp
var listId = "TestListId";
var member = new Member { EmailAddress = $"githubTestAccount@test.com", Status = Status.Subscribed };
member.MergeFields.Add("FNAME", "HOLY");
member.MergeFields.Add("LNAME", "COW");
await this.mailChimpManager.Members.AddOrUpdateAsync(listId, member);
```
