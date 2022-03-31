using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ConsoleTables;
using Kmd.Studica.Programmes.Client;
using Microsoft.Rest;

namespace ExternalApiExamples
{
    public class ActivityReportsExample
    {
        private readonly ITokenProvider tokenProvider;
        private readonly AppConfiguration configuration;

        public ActivityReportsExample(ITokenProvider tokenProvider, AppConfiguration configuration)
        {
            this.tokenProvider = tokenProvider;
            this.configuration = configuration;
        }

        public async Task ExecuteStudentActivityReports()
        {
            Console.Write("Executing student activity reports example");

            using var programmesClient = new KMDStudicaProgrammes(new TokenCredentials(tokenProvider));
            programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
                ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
                : new Uri(configuration.ProgrammesBaseUri);

            var result = await programmesClient.StudentActivityReportsExternal.GetWithHttpMessagesAsync(
                periodFrom: new DateTime(DateTime.Today.Year - 1, 1, 1),
                periodTo: new DateTime(DateTime.Today.Year - 1, 12, 31),
                schoolCode: configuration.SchoolCode,
                customHeaders: new Dictionary<string, List<string>>
                {
                    { "Logic-Api-Key", new List<string> { configuration.StudicaExternalApiKey } }
                });

            Console.WriteLine($"Got {result.Body.Count} activity reports from API");

            ConsoleTable
                .From(result.Body)
                .Write();
        }

        public async Task ExecuteActivitiesReport()
        {
            Console.Write("Executing activity reports example");

            using var programmesClient = new KMDStudicaProgrammes(new TokenCredentials(tokenProvider));
            programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
                ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
                : new Uri(configuration.ProgrammesBaseUri);

            var result = await programmesClient.ActivitiesExternal.GetWithHttpMessagesAsync(
                periodFrom: new DateTime(DateTime.Today.Year - 1, 1, 1),
                periodTo: new DateTime(DateTime.Today.Year - 1, 12, 31),
                schoolCode: configuration.SchoolCode,
                pageNumber: 1,
                pageSize: 100,
                inlineCount: true,
                customHeaders: new Dictionary<string, List<string>>
                {
                    { "Logic-Api-Key", new List<string> { configuration.StudicaExternalApiKey } }
                });
            
            Console.WriteLine($"Got {result.Body.TotalItems} total activity reports from query");

            ConsoleTable
                .From(result.Body.Items)
                .Write();
        }
    }
}