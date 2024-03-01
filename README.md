# .NET 8 Web Api Project Template
This is a web api project template which has EF Core, Swagger, Api Versioning, NLog, and signalR setup.

## How to Use
***Note***: I have created and tested this template in `Visual Studio 2022 version 17.8`. It should work in version `>17.0`.

* Download the Template: Visit the GitHub [Repository](https://github.com/PureJoyMind/ApiSetupProjectTemplate) of the template project.
* Get the Template File: Download the template file from the Release section of the repository.
* Copy the Template file to `C:\Users\{User}\Documents\Visual Studio 2022\Templates\ProjectTemplates`
* Create A new Project and select the template from the list of templates. If you don't see the template search for it.
   ![Create New Project in Visual Studio 2022](https://github.com/PureJoyMind/ApiSetupProjectTemplate/assets/27802665/e31f0c7a-11b8-4715-bfda-8fe890a6fb82)
### Creation
Choose this Template when creating a new project in visual studio. The nuget packages are updated as needed up to 3/1/2024. 
I have upgraded the packages which had vulnerabilities. 

### Features
* ***Versioning***: The project contains a default Controller, which has two methods. One of them is commented out. Its purpose is to show how to use Api versioning.
* ***Logging***: I have used NLog as the projects default logger. You can see how to inject and use it in the project in the Default controller. There is a `nlog.config` file in the root of the project. Look at [NLog](https://github.com/nlog/nlog/wiki)'s official docs to see how you can twick its settings. I have setup three log levels(Info, Debug, Error) which are written in separate files outside of the project runtime folder in a folder called Logs. 
* ***DbContext***: In order to use EF Core, you need to know what you are doing. in the `Program.cs` file you can see `builder.Services.AddDbContext<DataContext>` which adds the connection string. you can change this as you want. Or you can move the connection string to `appsettings.json`. You can then inject and use the DbContext whenever you want.
* ***SignalR***: Even though .NET 8 already has the SignalR packages by default, I have set the project in a way that you can immediately write signalR code upon project creation. In the `Program.cs` file you can see `app.MapHub<DefaultHub>("hub");` which means that the route to SignalR's websocket is `/hub`. The Hub that I have setup is Strong-Typed, which means that you can call client methods by simply calling the methods name (You have to declare clients methods in the Interface. See Strong-Typed Hubs in official [Docs](https://learn.microsoft.com/en-us/aspnet/signalr/overview/guide-to-the-api/hubs-api-guide-server#strongly-typed-hubs)).
