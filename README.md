# KMD Studica Examples

A dotnet client library with examples how to use Studica external API via Logic Gateway.

## Getting started 

* The samples uses .net core 3.1 LTS which can be downloaded from here: https://dotnet.microsoft.com/download.
* To run the sample first edit the `appsettings.json` configuration file and provide valid information for authorization.
* Samples contain REST clients, which were generated by Autorest package, that can be obtained from here: https://github.com/Azure/autorest/tree/master/docs/powershell.

## How to configure connection to Studica External API via Logic Gateway

Perhaps the easiest way to configure the connection.

```json
{
  "TokenProvider": {
    "AuthorizationScope": "",
    "ClientId": "",
    "ClientSecret": ""
  },
  "StudicaExternalApiKey": "",
  "SchoolCode": ""
}
```

1. Create a subscription in [Logic Console](https://console.kmdlogic.io).
2. Request a client credentials. Once issued you can view the `ClientId`, `ClientSecret` and `AuthorizationScope` (_Subscriptions/Client Credentials_).
3. Generate two API Keys for _KMD Studica (Review)_ product (_API Marketplace/Products/KMD Studica (Review)/Create api key_). They can be used interchangeably. That gives you `StudicaExternalApiKey`. API key must be sent as a request header named `Logic-Api-Key`.
4. `SchoolCode` is the required parameter for each request to Studica external API.
5. OpenAPI specifications can be found in API Marketplace (_API Marketplace/APIs/KMD Studica (Review) - <--Name of endpoint-->/Learn more_)
6. Powershell scripts `generate.ps1` are located in the folders of each external API. Parameter `--input-file` has the direct reference to the OpenAPI spec file located in Logic blob storage.

## Currently available APIs in Logic API Marketplace

* KMD Studica (Review) - Programmes
* KMD Studica (Review) - School Administration
* KMD Studica (Review) - Students

## Data available through APIs

![alt text][api_diagram]

[api_diagram]: https://github.com/kmdstudica/external-api-examples/blob/master/docs/external-api-diagram.png?raw=true "API Diagram"