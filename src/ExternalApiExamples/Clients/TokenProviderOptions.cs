using System;

namespace ExternalApiExamples.Clients
{
    public sealed class TokenProviderOptions
    {
        /// <summary>
        /// Gets or sets the Logic Identity authorization token issuer.
        /// </summary>
        /// <remarks>
        /// This option should not be overridden except for testing purposes.
        /// </remarks>
        public Uri AuthorizationTokenIssuer { get; set; }

        /// <summary>
        /// Gets or sets the Logic Identity authorization scope.
        /// </summary>
        /// <remarks>
        /// This option should not be overridden except for testing purposes.
        /// </remarks>
        public string AuthorizationScope { get; set; } 

        /// <summary>
        /// Gets or sets the client credentials identifier.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the client credentials secret.
        /// </summary>
        public string ClientSecret { get; set; }
    }
}