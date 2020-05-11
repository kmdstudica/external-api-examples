using ConsoleTables;
using Kmd.Studica.Students.Client;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExternalApiExamples
{
    public class StudentsExample
    {
        private readonly ITokenProvider tokenProvider;
        private readonly AppConfiguration configuration;

        public StudentsExample(ITokenProvider tokenProvider, AppConfiguration configuration)
        {
            this.tokenProvider = tokenProvider;
            this.configuration = configuration;
        }

        public async Task Execute()
        {
            Console.WriteLine("Executing student example");

            using var studentsClient = new KMDStudicaStudents(new TokenCredentials(tokenProvider));
            studentsClient.BaseUri = string.IsNullOrEmpty(configuration.StudentsBaseUri)
                ? new Uri("https://gateway.kmdlogic.io/studica/students/v1")
                : new Uri(configuration.StudentsBaseUri);

            var result = await studentsClient.StudentsExternal.GetWithHttpMessagesAsync(
                studyStartDateFrom: DateTime.Now.AddMonths(-12),
                studyStartDateTo: DateTime.Now.AddMonths(6),
                schoolCode: configuration.SchoolCode,
                pageNumber: 1,
                pageSize: 10,
                inlineCount: true,
                customHeaders: new Dictionary<string, List<string>>
                {
                    { "Logic-Api-Key", new List<string> { configuration.StudicaExternalApiKey } }
                });

            Console.WriteLine($"Got {result.Body.TotalItems} students from API");

            ConsoleTable
                .From(result.Body.Items)
                .Write();
        }

        public async Task ExecuteBulk()
        {
            Console.WriteLine("Executing bulk student example");

            using var studentsClient = new KMDStudicaStudents(new TokenCredentials(tokenProvider));
            studentsClient.BaseUri = string.IsNullOrEmpty(configuration.StudentsBaseUri)
                ? new Uri("https://gateway.kmdlogic.io/studica/students/v1")
                : new Uri(configuration.StudentsBaseUri);

            var result = await studentsClient.BulkStudentsExternal.PostWithHttpMessagesAsync(
                studentIds: new[] { Guid.NewGuid() },
                schoolCode: configuration.SchoolCode,
                customHeaders: new Dictionary<string, List<string>>
                {
                    { "Logic-Api-Key", new List<string> { configuration.StudicaExternalApiKey } }
                });

            Console.WriteLine($"Got {result.Body} students from API");

            ConsoleTable
                .From(result.Body)
                .Write();
        }
    }
}