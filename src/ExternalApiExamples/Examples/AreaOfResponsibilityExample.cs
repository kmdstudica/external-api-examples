using ConsoleTables;
using Kmd.Studica.SchoolAdministration.Client;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExternalApiExamples
{
    public class AreaOfResponsibilityExample
    {
        private readonly ITokenProvider tokenProvider;
        private readonly AppConfiguration configuration;

        public AreaOfResponsibilityExample(ITokenProvider tokenProvider, AppConfiguration configuration)
        {
            this.tokenProvider = tokenProvider;
            this.configuration = configuration;
        }

        public async Task Execute()
        {
            Console.WriteLine("Executing school hour entry example");

            using var schoolAdministrationClient = new KMDStudicaSchoolAdministration(new TokenCredentials(tokenProvider));
            schoolAdministrationClient.BaseUri = string.IsNullOrEmpty(configuration.SchoolAdministrationBaseUri)
                ? new Uri("https://gateway.kmdlogic.io/studica/school-administration/v1")
                : new Uri(configuration.SchoolAdministrationBaseUri);

            var result = await schoolAdministrationClient.AreasOfResponsibilityExternal.GetWithHttpMessagesAsync(
                schoolCode: configuration.SchoolCode,
                pageNumber: 1,
                pageSize: 10,
                inlineCount: true,
                customHeaders: new Dictionary<string, List<string>>
                {
                    { "Logic-Api-Key", new List<string> { configuration.StudicaExternalApiKey } }
                });

            Console.WriteLine($"Got {result.Body.TotalItems} plans from API");

            ConsoleTable
                .From(result.Body.Items)
                .Write();
        }
    }
}