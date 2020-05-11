using Microsoft.Rest;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace ExternalApiExamples
{
    internal class LocalTestTokenProvider : ITokenProvider
    {
        private readonly string developmentToken;

        public LocalTestTokenProvider(string developmentToken)
        {
            this.developmentToken = developmentToken;
        }

        public Task<AuthenticationHeaderValue> GetAuthenticationHeaderAsync(CancellationToken cancellationToken)
        {
            var authHeader = new AuthenticationHeaderValue("bearer", developmentToken);
            return Task.FromResult(authHeader);
        }
    }
}