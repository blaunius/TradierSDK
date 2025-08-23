# TradierSDK
Open Source SDK for the Tradier HTTP client

https://documentation.tradier.com/brokerage-api/trading/getting-started

# Initialization
There are two clients: `TradierClient` for production and `TradierSandboxClient` for paper trading.
Both clients can be used at the same time, but only if you provide the access token explicitly in the constructor.

## Implicit
```csharp
TradierConfig.AccessToken = "some-token";

var client = new TradierClient();
// OR
var sandboxClient = new TradierSandboxClient();
// OR (ASP.NET Core)
services.AddHttpClient<ITradierClient, TradierClient>();
// OR (ASP.NET Core)
services.AddHttpClient<ITradierSandboxClient, TradierSandboxClient>();
```
## Explicit
```csharp
var sandboxClient = new TradierSandboxClient(new TradierAuthentication(config["Tradier:AccessTokens:Sandbox"], TradierConfig.RedirectUri));
// AND/OR
var productionClient = new TradierClient(new TradierAuthentication(config["Tradier:AccessTokens:Production"], TradierConfig.RedirectUri));
// AND/OR (ASP.NET Core)
services.AddHttpClient();
services.AddScoped<ITradierClient, TradierClient>(sp => new TradierClient(new TradierAuthentication(config["Tradier:AccessTokens:Production"], TradierConfig.RedirectUri)));
// AND/OR (ASP.NET Core)
services.AddScoped<ITradierClient, TradierSandboxClient>(sp => new TradierClient(new TradierAuthentication(config["Tradier:AccessTokens:Production"], TradierConfig.RedirectUri)));
```

# Usage
Each service has its own class. You need to instantiate the service with the client and then call the methods, or if using ASP.NET Core, you can inject each service independently.
```csharp
var watchListService = new TradierWatchListService(client);
var watchLists = await watchListService.GetWatchlists();
```