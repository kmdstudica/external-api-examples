# KMD Studica Examples

A dotnet client library with examples how to use Studica external API via Logic Gateway.

## Getting started 

The samples uses .net core 3.1 LTS which can be downloaded from here: https://dotnet.microsoft.com/download
To run the sample first edit the `appsettings.json` configuration file and provide valid information for authorization.

## How to configure connection to Studica External API via Logic Gateway

Perhaps the easiest way to configure the connection.

```json
{
  "TokenProvider": {
    "AuthorizationScope": "",
    "ClientId": "",
    "ClientSecret": ""
  },
  "StudicaExternalApiKey": ""
}
```

1. Create a subscription in [Logic Console](https://console.kmdlogic.io).
2. Request a client credential. Once issued you can view the `ClientId`, `ClientSecret` and `AuthorizationScope` in [Logic Console](https://console.kmdlogic.io).
3. Once client credentials are provided, generate two API Keys for Studica product in API Marketplace (_API Marketplace/Products/KMD Studica (Review)/Create api key_). They can be used interchangeably. Any of them gives you `StudicaExternalApiKey`. This ApiKey must be sent as a request header named `Logic-Api-Key`.
4. OpenApi specifications can be found in API Marketplace (_API Marketplace/APIs/KMD Studica (Review) - <--Name of endpoint-->/Learn more_)

## Data avalaible through API

![alt text][api_diagram]

[api_diagram]: https://github.com/kmdstudica/external-api-examples/blob/master/docs/external-api-diagram.png?raw=true "API Diagram"