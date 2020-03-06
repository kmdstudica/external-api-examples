using ConsoleTables;
using Kmd.Studica.Programmes.Client;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExternalApiExamples
{
    public class EducationalProgrammesExample
    {
        private readonly ITokenProvider tokenProvider;
        private readonly AppConfiguration configuration;

        public EducationalProgrammesExample(ITokenProvider tokenProvider, AppConfiguration configuration)
        {
            this.tokenProvider = tokenProvider;
            this.configuration = configuration;
        }

        public async Task Execute()
        {
            Console.WriteLine("Executing educational programmes example");

            using var programmesClient = new KMDStudicaProgrammes(new TokenCredentials(tokenProvider));
            programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
                ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
                : new Uri(configuration.ProgrammesBaseUri);

            var result = await programmesClient.EducationalProgrammesExternal.GetWithHttpMessagesAsync(
                startDateFrom: DateTime.Now.AddMonths(-12),
                startDateTo: DateTime.Now.AddMonths(6),
                schoolCode: configuration.SchoolCode,
                pageNumber: 1,
                pageSize: 10,
                inlineCount: true,
                customHeaders: new Dictionary<string, List<string>>
                {
                    { "Logic-Api-Key", new List<string> { configuration.StudicaExternalApiKey } }
                });

            Console.WriteLine($"Got {result.Body.TotalItems} educational programmes from API");

            ConsoleTable
                .From(result.Body.Items)
                .Write();
        }
    }
}