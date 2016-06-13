Example:
IMailChimpManager manager = new MailChimpManager(apiKey); //if you have it in code
IMailChimpManager manager = new MailChimpManager(); //if you have it in config

Get Conversations - 
var conversations = await this._mailChimpManager.Conversations.GetAllAsync();

Project is hosted on GitHub:
https://github.com/brandonseydel/MailChimp.Net