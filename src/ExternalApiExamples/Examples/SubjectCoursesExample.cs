using ConsoleTables;
using Kmd.Studica.Programmes.Client;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExternalApiExamples
{
    public class SubjectCoursesExample
    {
        private readonly ITokenProvider tokenProvider;
        private readonly AppConfiguration configuration;

        public SubjectCoursesExample(ITokenProvider tokenProvider, AppConfiguration configuration)
        {
            this.tokenProvider = tokenProvider;
            this.configuration = configuration;
        }

        public async Task Execute()
        {
            Console.WriteLine("Executing subject courses example");

            using var programmesClient = new KMDStudicaProgrammes(new TokenCredentials(tokenProvider));
            programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
                ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
                : new Uri(configuration.ProgrammesBaseUri);

            var result = await programmesClient.SubjectCoursesExternal.GetWithHttpMessagesAsync(
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

            Console.WriteLine($"Got {result.Body.TotalItems} subject courses from API");

            ConsoleTable
                .From(result.Body.Items)
                .Write();
        }

        public async Task ExecuteBulk()
        {
            Console.WriteLine("Executing bulk subject courses example");

            using var programmesClient = new KMDStudicaProgrammes(new TokenCredentials(tokenProvider));
            programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
                ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
                : new Uri(configuration.ProgrammesBaseUri);

            var result = await programmesClient.BulkSubjectCoursesExternal.PostWithHttpMessagesAsync(
                subjectCourseIds: new[] { Guid.NewGuid() },
                schoolCode: configuration.SchoolCode,
                customHeaders: new Dictionary<string, List<string>>
                {
                    { "Logic-Api-Key", new List<string> { configuration.StudicaExternalApiKey } }
                });

            Console.WriteLine($"Got {result.Body} subject courses from API");

            ConsoleTable
                .From(result.Body)
                .Write();
        }
    }
}