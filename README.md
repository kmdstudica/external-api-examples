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
  "StudicaExternalApiBaseAddress": "",
  "StudicaExternalApiKey": ""
}
```

To get started:

1. Create a subscription in [Logic Console](https://console.kmdlogic.io).
2. Request a client credential. Once issued you can view the `ClientId`, `ClientSecret` and `AuthorizationScope` in [Logic Console](https://console.kmdlogic.io).
3. Once client credentials are provided, generate two API Keys for Studica product in API Marketplace (_API Marketplace/Products/Studica/Create api key_). They can be used interchangeably. Any of them gives you `StudicaExternalApiKey`.
4. Provide address to the Studica API from _API Marketplace/APIs/**--PROVIDE STUDICA API ITEM--**_.

## Data avalaible through API

![alt text][api_diagram]

[api_diagram]: https://github.com/kmdstudica/external-api-examples/blob/master/docs/external-api-diagram.png?raw=true "API Diagram"