using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ConsoleTables;
using Kmd.Studica.Programmes.Client;
using Microsoft.Rest;

namespace ExternalApiExamples
{
    public class SchoolCoursesExample
    {
        private readonly ITokenProvider tokenProvider;
        private readonly AppConfiguration configuration;

        public SchoolCoursesExample(ITokenProvider tokenProvider, AppConfiguration configuration)
        {
            this.tokenProvider = tokenProvider;
            this.configuration = configuration;
        }

        /// <summary>
        /// Use the school courses service to get a generic list of school courses
        /// </summary>
        public async Task Execute()
        {
            Console.WriteLine("Executing school courses example");

            using var programmesClient = new KMDStudicaProgrammes(new TokenCredentials(tokenProvider));
            programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
                ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
                : new Uri(configuration.ProgrammesBaseUri);

            var result = await programmesClient.SchoolCoursesExternal.GetWithHttpMessagesAsync(
                periodFrom: DateTime.Now.AddMonths(-2),
                periodTo: DateTime.Now.AddMonths(2),
                schoolCode: configuration.SchoolCode,
                pageNumber: 1,
                pageSize: 30,
                inlineCount: true,
                customHeaders: new Dictionary<string, List<string>>
                {
                    {"Logic-Api-Key", new List<string> {configuration.StudicaExternalApiKey}}
                });

            Console.WriteLine($"Got {result.Body.TotalItems} school courses courses from API");

            ConsoleTable
                .From(result.Body.Items)
                .Write();
        }

        /// <summary>
        /// Use the school courses service to get a detailed list of school courses based on a list of students and a given interval
        /// The is e.g. used for correlating with school based internships.
        /// </summary>
        public async Task ExecuteStudentSchoolCourses()
        {
            Console.WriteLine("Executing school courses example");

            using var programmesClient = new KMDStudicaProgrammes(new TokenCredentials(tokenProvider));
            programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
                ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
                : new Uri(configuration.ProgrammesBaseUri);

            var result = await programmesClient.StudentSchoolCoursesExternal.GetWithHttpMessagesAsync(
                studentIds: new[] { Guid.NewGuid() },
                periodFrom: DateTime.Now.AddMonths(-2),
                periodTo: DateTime.Now.AddMonths(2),
                schoolCode: configuration.SchoolCode,
                customHeaders: new Dictionary<string, List<string>>
                {
                    {"Logic-Api-Key", new List<string> {configuration.StudicaExternalApiKey}}
                });

            Console.WriteLine($"Got {result.Body.Count} school courses courses from API");

            ConsoleTable
                .From(result.Body)
                .Write();
        }
    }
}