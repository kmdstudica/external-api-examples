using System;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Rest;

namespace ExternalApiExamples.Clients
{
    public class StudicaHostToHostTokenProvider : ITokenProvider
    {
        private readonly string secret;

        public StudicaHostToHostTokenProvider(string secret)
        {
            this.secret = secret;
        }

        public Task<AuthenticationHeaderValue> GetAuthenticationHeaderAsync(CancellationToken cancellationToken)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
            var header = new JwtHeader(credentials);
            var now = DateTimeOffset.Now.ToUnixTimeSeconds();
            var iatStr = now.ToString(CultureInfo.InvariantCulture);
            var expStr = (now + 300).ToString(CultureInfo.InvariantCulture);
            var payload = GetSystemUserPayload(iatStr, expStr);

            var secToken = new JwtSecurityToken(header, payload);
            var handler = new JwtSecurityTokenHandler();

            var auth = handler.WriteToken(secToken);
            return Task.FromResult(new AuthenticationHeaderValue("Bearer", auth));
        }

        private JwtPayload GetSystemUserPayload(string iatStr, string expStr) =>
            new JwtPayload
            {
                { "sub", new Guid("00000000-0000-0000-0000-000000000001") },
                { "iss", "studica-backend" },
                { "aud", "studica-backend" },
                { "CorrelationId", Guid.NewGuid() },
                { "IsSystemUser", "true" },
                { "nbf", iatStr },
                { "iat", iatStr },
                { "exp", expStr }
            };
    }
}