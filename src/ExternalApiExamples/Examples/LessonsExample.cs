using ConsoleTables;
using Kmd.Studica.Programmes.Client;
using Kmd.Studica.Programmes.Client.Models;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExternalApiExamples
{
    public class LessonsExample
    {
        private readonly ITokenProvider tokenProvider;
        private readonly AppConfiguration configuration;

        public LessonsExample(ITokenProvider tokenProvider, AppConfiguration configuration)
        {
            this.tokenProvider = tokenProvider;
            this.configuration = configuration;
        }

        public async Task Execute()
        {
            Console.WriteLine("Lessons example");

            using var programmesClient = new KMDStudicaProgrammes(new TokenCredentials(tokenProvider));
            programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
                ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
                : new Uri(configuration.ProgrammesBaseUri);

            var result = await programmesClient.LessonsExternal.GetWithHttpMessagesAsync(
                dateFrom: DateTime.Now.AddMonths(-12),
                dateTo: DateTime.Now.AddMonths(6),
                schoolCode: configuration.SchoolCode,
                pageNumber: 1,
                pageSize: 10,
                inlineCount: true,
                customHeaders: new Dictionary<string, List<string>>
                {
                    { "Logic-Api-Key", new List<string> { configuration.StudicaExternalApiKey } }
                });

            Console.WriteLine($"Got {result.Body.TotalItems} lessons from API");

            ConsoleTable
                .From(result.Body.Items)
                .Write();
        }

        public async Task ExecuteRegisterLesson()
        {
            Console.WriteLine("Register lesson example");

            using var programmesClient = new KMDStudicaProgrammes(new TokenCredentials(tokenProvider));
            programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
                ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
                : new Uri(configuration.ProgrammesBaseUri);

            var result = await programmesClient.RegisterLessonExternal.PostWithHttpMessagesAsync(
                body: new RegisterLessonExternalCommand(
                    id: Guid.NewGuid(),
                    subjectCourseId: Guid.NewGuid(),
                    roomId: Guid.NewGuid(),
                    date: DateTime.Now,
                    startTime: "11:15",
                    endTime: "12:00",
                    teacherIds: new List<Guid>(),
                    schoolCode: configuration.SchoolCode),
                customHeaders: new Dictionary<string, List<string>>
                {
                    { "Logic-Api-Key", new List<string> { configuration.StudicaExternalApiKey } }
                });

            if (result.Response.IsSuccessStatusCode)
                Console.WriteLine("[Register lesson] Successfully added new lesson");
            else
                Console.WriteLine("[Register lesson] Couldn't add new lesson");
        }

        public async Task ExecuteBulk()
        {
            Console.WriteLine("Bulk lessons example");

            using var programmesClient = new KMDStudicaProgrammes(new TokenCredentials(tokenProvider));
            programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
                ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
                : new Uri(configuration.ProgrammesBaseUri);

            var result = await programmesClient.BulkLessonsExternal.PostWithHttpMessagesAsync(
                lessonIds: new[] { Guid.NewGuid() },
                schoolCode: configuration.SchoolCode,
                customHeaders: new Dictionary<string, List<string>>
                {
                    { "Logic-Api-Key", new List<string> { configuration.StudicaExternalApiKey } }
                });

            Console.WriteLine($"Got {result.Body} lessons from API");

            ConsoleTable
                .From(result.Body)
                .Write();
        }
    }
}