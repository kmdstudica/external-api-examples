using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;
using Microsoft.Rest.Serialization;
using Newtonsoft.Json;

namespace ExternalApiExamples.Clients
{
    public class TokenProvider : ITokenProvider
    {
        private readonly HttpClient httpClient;
        private readonly JsonSerializerSettings jsonSerializerSettings;
        private readonly TokenProviderOptions tokenProviderOptions;
        
        private TokenResponse currentToken;
        private DateTime expiration;
        

        public TokenProvider(HttpClient httpClient,
            JsonSerializerSettings jsonSerializerSettings, 
            TokenProviderOptions tokenProviderOptions)
        {
            this.httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            this.jsonSerializerSettings = jsonSerializerSettings;
            this.tokenProviderOptions = tokenProviderOptions;
        }

        public async Task<AuthenticationHeaderValue> GetAuthenticationHeaderAsync(CancellationToken cancellationToken)
        {
            if (this.currentToken != null && this.expiration > DateTime.Now)
            {
                return new AuthenticationHeaderValue(this.currentToken.TokenType,
                    this.currentToken.AccessToken);
            }

            this.currentToken = null;

            var expire = DateTime.Now;

            var token = await this.RequestToken(
                    this.httpClient,
                    this.tokenProviderOptions.AuthorizationTokenIssuer,
                    this.tokenProviderOptions.ClientId,
                    this.tokenProviderOptions.AuthorizationScope,
                    this.tokenProviderOptions.ClientSecret,
                    cancellationToken)
                .ConfigureAwait(false);

            this.expiration = expire.AddSeconds(token.ExpiresIn - 5);

            if (string.IsNullOrEmpty(token.AccessToken))
            {
                throw new Exception("Unable to get a token from the token issuer");
            }

            this.currentToken = token;

            return new AuthenticationHeaderValue(this.currentToken.TokenType,
                this.currentToken.AccessToken);
        }

        private async Task<TokenResponse> RequestToken(HttpClient httpClient, Uri uriAuthorizationServer,
            string clientId, string scope, string clientSecret, CancellationToken cancellationToken)
        {
            HttpResponseMessage responseMessage;

            var tokenRequest = new HttpRequestMessage(HttpMethod.Post, uriAuthorizationServer);
            tokenRequest.Content = new FormUrlEncodedContent(
                new[]
                {
                    new KeyValuePair<string, string>("grant_type", "client_credentials"),
                    new KeyValuePair<string, string>("client_id", clientId),
                    new KeyValuePair<string, string>("scope", scope),
                    new KeyValuePair<string, string>("client_secret", clientSecret),
                });

            responseMessage = await httpClient.SendAsync(tokenRequest, cancellationToken).ConfigureAwait(false);

            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception("Unable to access the token issuer");
            }

            var json = await responseMessage
                .Content
                .ReadAsStringAsync()
                .ConfigureAwait(false);

            return SafeJsonConvert.DeserializeObject<TokenResponse>(json, this.jsonSerializerSettings);
        }
    }
}