using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleTables;
using Kmd.Studica.Programmes.Client;
using Microsoft.Rest;

namespace ExternalApiExamples
{
    public class StudentInternshipExample
    {
        private readonly ITokenProvider tokenProvider;
        private readonly AppConfiguration configuration;

        public StudentInternshipExample(ITokenProvider tokenProvider, AppConfiguration configuration)
        {
            this.tokenProvider = tokenProvider;
            this.configuration = configuration;
        }

        public async Task Execute()
        {
            Console.WriteLine("Executing school courses example");

            using var programmesClient = new KMDStudicaProgrammes(new TokenCredentials(tokenProvider));
            programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
                ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
                : new Uri(configuration.ProgrammesBaseUri);

            var result = await programmesClient.StudentInternshipExternal.GetWithHttpMessagesAsync(
                periodFrom: DateTime.Now.AddMonths(-2),
                periodTo: DateTime.Now.AddMonths(2),
                schoolCode: configuration.SchoolCode,
                customHeaders: new Dictionary<string, List<string>>
                {
                    { "Logic-Api-Key", new List<string> { configuration.StudicaExternalApiKey } }
                });

            Console.WriteLine($"Got {result.Body.Count()} student internhips from API");

            ConsoleTable
                .From(result.Body)
                .Write();
        }
    }
}