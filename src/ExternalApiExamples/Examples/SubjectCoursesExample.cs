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
                startDateFrom: DateTime.Now.AddMonths(-2),
                startDateTo: DateTime.Now.AddMonths(2),
                schoolCode: configuration.SchoolCode,
                lmsIndicator: true,
                pageNumber: 1,
                pageSize: 30,
                inlineCount: true,
                customHeaders: new Dictionary<string, List<string>>
                {
                    {"Logic-Api-Key", new List<string> {configuration.StudicaExternalApiKey}}
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
                subjectCourseIds: new[] {Guid.NewGuid()},
                schoolCode: configuration.SchoolCode,
                customHeaders: new Dictionary<string, List<string>>
                {
                    {"Logic-Api-Key", new List<string> {configuration.StudicaExternalApiKey}}
                });

            ConsoleTable
                .From(result.Body)
                .Write();
        }

        public async Task ExecuteStudentSubjectCourses()
        {
            Console.WriteLine("Executing student subject courses example");

            using var programmesClient = new KMDStudicaProgrammes(new TokenCredentials(tokenProvider));
            programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
                ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
                : new Uri(configuration.ProgrammesBaseUri);

            var result = await programmesClient.StudentSubjectCoursesExternal.GetWithHttpMessagesAsync(
                studentIds: new[] {Guid.NewGuid()},
                pageNumber: 1,
                pageSize: 10,
                inlineCount: true,
                schoolCode: configuration.SchoolCode,
                customHeaders: new Dictionary<string, List<string>>
                {
                    {"Logic-Api-Key", new List<string> {configuration.StudicaExternalApiKey}}
                });

            Console.WriteLine($"Got {result.Body.TotalItems} student subject courses from API");

            ConsoleTable
                .From(result.Body.Items)
                .Write();
        }
        
        public async Task ExecuteActiveSubjectCourses()
        {
            Console.WriteLine("Executing active subject courses example");

            using var programmesClient = new KMDStudicaProgrammes(new TokenCredentials(tokenProvider));
            programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
                ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
                : new Uri(configuration.ProgrammesBaseUri);

            var result = await programmesClient.ActiveSubjectCoursesExternal.GetWithHttpMessagesAsync(
                subjectCoursesActiveOnOrAfterDate: DateTime.Today, 
                schoolCode: configuration.SchoolCode,
                lmsIndicator: true,
                pageNumber: 1,
                pageSize: 30,
                inlineCount: true,
                customHeaders: new Dictionary<string, List<string>>
                {
                    {"Logic-Api-Key", new List<string> {configuration.StudicaExternalApiKey}}
                });

            Console.WriteLine($"Got {result.Body.TotalItems} subject courses from API");

            ConsoleTable
                .From(result.Body.Items)
                .Write();
        }
    }
}