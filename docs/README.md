# TradierSDK
Open Source SDK for the Tradier HTTP client

https://documentation.tradier.com/brokerage-api/trading/getting-started

Tradier APIs use the OAuth 2.0 protocol for authentication and authorization. 
Publicly we support the Authorization Code flow (server-side application). 
OAuth 2.0 is a simple protocol and a developer can integrate with Tradier’s OAuth 2.0 endpoints easily, especially using client libraries.
The Flow In its most basic form, you will register your application with Tradier, redirect a browser to a URL, parse a token from the responding redirect, then send the token to whichever Tradier API you wish to access.
Authorization Codes Authorization codes are short-lived (they expire in 10 minutes). 
A code is provided after an investor authorizes your application for access to their account. 
These codes are exchanged for access tokens which can be used to make API requests.
Access Tokens Access tokens (or Bearer tokens) are provided after a successful authorization code exchange. 
These tokens expire every 24 hours – no questions asked. 
Once a token expires you’ll need to exchange another authorization code to receive another access token.
Refresh Tokens Once refresh tokens are enabled for your application, you will receive the refresh token alongside every access token. 
You can exchange a refresh token for a new access token. 
Refresh tokens do not expire.