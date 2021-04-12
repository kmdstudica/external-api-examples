using ConsoleTables;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Kmd.Studica.Programmes.Client;

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

        public async Task Execute()
        {
            Console.Write("Executing activity reports example");

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
                    {"Logic-Api-Key", new List<string> {configuration.StudicaExternalApiKey}}
                });

            Console.WriteLine($"Got {result.Body.Count} activity reports from API");

            ConsoleTable
                .From(result.Body)
                .Write();
        }
    }
}