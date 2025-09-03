# TradierSDK

Open Source SDK for the Tradier HTTP client

[Tradier Brokerage API Documentation](https://documentation.tradier.com/brokerage-api/trading/getting-started)

## Overview
TradierSDK is a .NET library for interacting with the Tradier Brokerage API. It supports both production and sandbox environments, making it easy to integrate Tradier trading, market data, and account services into your .NET applications.

## Features
- .NET 8 and .NET 9 support
- Production and sandbox (paper trading) clients
- Easy integration with ASP.NET Core DI
- Service-based architecture for API endpoints
- Comprehensive unit tests

## Getting Started

### Initialization
There are two clients:
- `TradierClient` for production
- `TradierSandboxClient` for paper trading

Both clients can be used at the same time, but only if you provide the access token explicitly in the constructor.

#### Implicit Initialization
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

#### Explicit Initialization
```csharp
var sandboxClient = new TradierSandboxClient(
    new TradierAuthentication(config["Tradier:AccessTokens:Sandbox"], TradierConfig.RedirectUri)
);
// AND/OR
var productionClient = new TradierClient(
    new TradierAuthentication(config["Tradier:AccessTokens:Production"], TradierConfig.RedirectUri)
);
// AND/OR (ASP.NET Core)
services.AddHttpClient();
services.AddScoped<ITradierClient, TradierClient>(sp =>
    new TradierClient(new TradierAuthentication(config["Tradier:AccessTokens:Production"], TradierConfig.RedirectUri))
);
// AND/OR (ASP.NET Core)
services.AddScoped<ITradierClient, TradierSandboxClient>(sp =>
    new TradierClient(new TradierAuthentication(config["Tradier:AccessTokens:Production"], TradierConfig.RedirectUri))
);
```

### Usage
Each service has its own class. Instantiate the service with the client and call the methods, or inject the service in ASP.NET Core.

```csharp
var watchListService = new TradierWatchListService(client);
var watchLists = await watchListService.GetWatchlists();
```

## Contributing
Contributions are welcome! Please open issues or submit pull requests on GitHub.

## License
This project is open source and available under the MIT License.
