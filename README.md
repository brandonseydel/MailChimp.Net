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
# Status
Progress on full implementation
<ul>
<li>API **100%**</li>
<li>Authorized Apps **100%**</li>
<li>Automations **100%**</li>
<li>Batch Operations **100%**</li>
<li>Campaigns **100%**</li>
<li>Campaign Content **100%**</li>
<li>Campaing Feedback **100%**</li>
<li>Campaign Folders **100%**</li>
<li>Campaing Send Checklist **100%**</li>
<li>Conversations **100%**</li>
<li>Conversations Messages **100%**</li>
<li>ECommerce Stores **100%**</li>
<li>File Manager Files **100%**</li>
<li>File Manager Folders **100%**</li>
<li>Lists **100%**</li>
<li>List Abuse Reports **100%**</li>
<li>List Activity **100%**</li>
<li>List Clients **100%**</li>
<li>List Growth History **100%**</li>
<li>List Interest Categories **100%**</li>
<li>List Members **100%**</li>
<li>List Segments **100%**</li>
<li>List Web Hooks **100%**</li>
<li>Template Folders **100%**</li>
<li>Templates **100%**</li>
<li>Template Default Content **100%**</li>
<li>Reports **100%**</li>
<li>Report Click Reports **100%**</li>
<li>Report Domain Performance **100%**</li>
<li>Report EepURL Reports **100%**</li>
<li>Report Email Activity **100%**</li>
<li>Report Location **100%**</li>
<li>Report Sent To **100%**</li>
<li>Report Sub-Reports **100%**</li>
<li>Report Unsubscribes **100%**</li>
<li>ECommerce Carts **100%**</li>
<li>ECommerce Customers **100%**</li>
<li>ECommerce Orders **100%**</li>
<li>ECommerce Order Lines **100%**</li>
<li>ECommerce Products **100%**</li>
<li>ECommerce Product Variants **100%**</li>
</ul>
