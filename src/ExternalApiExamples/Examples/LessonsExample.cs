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

        public async Task ExecuteGet()
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

        public async Task ExecuteGetUnscheduled()
        {
            Console.WriteLine("Get unscheduled lessons example");

            using var programmesClient = new KMDStudicaProgrammes(new TokenCredentials(tokenProvider));
            programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
                ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
                : new Uri(configuration.ProgrammesBaseUri);

            var result = await programmesClient.UnscheduledLessonsExternal.GetWithHttpMessagesAsync(
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

        public async Task ExecuteAddLessons()
        {
            Console.WriteLine("Add lessons example");

            using var programmesClient = new KMDStudicaProgrammes(new TokenCredentials(tokenProvider));
            programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
                ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
                : new Uri(configuration.ProgrammesBaseUri);

            var result = await programmesClient.AddLessonsExternal.PostWithHttpMessagesAsync(
                newLessons: new[]
                {
                    new NewLessonExternal
                    {
                        Id = Guid.NewGuid(),
                        ExternalLessonId = "external id 1",
                        SubjectCourseId = Guid.NewGuid(),
                        StartTime = "11:15",
                        EndTime = "12:00",
                        Date = DateTime.Now,
                        RoomIds = new[]{ Guid.NewGuid() },
                        TeacherIds = new[]{ Guid.NewGuid() },
                    }
                },
                schoolCode: configuration.SchoolCode,
                customHeaders: new Dictionary<string, List<string>>
                {
                    { "Logic-Api-Key", new List<string> { configuration.StudicaExternalApiKey } }
                });

            if (result.Response.IsSuccessStatusCode)
                Console.WriteLine("[Add lesson] Successfully added new lessons");
            else
                Console.WriteLine("[Add lesson] Couldn't add new lessons");
        }

        public async Task ExecuteEditLesson()
        {
            Console.WriteLine("Edit lesson example");

            using var programmesClient = new KMDStudicaProgrammes(new TokenCredentials(tokenProvider));
            programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
                ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
                : new Uri(configuration.ProgrammesBaseUri);

            var result = await programmesClient.EditLessonExternal.PostWithHttpMessagesAsync(
                body: new EditLessonExternalCommand(
                    id: Guid.NewGuid(),
                    subjectCourseId: Guid.NewGuid(),
                    roomIds: new[] { Guid.NewGuid() },
                    date: DateTime.Now,
                    startTime: "11:15",
                    endTime: "12:00",
                    teacherIds: new[] { Guid.NewGuid() },
                    schoolCode: configuration.SchoolCode),
                customHeaders: new Dictionary<string, List<string>>
                {
                    { "Logic-Api-Key", new List<string> { configuration.StudicaExternalApiKey } }
                });

            if (result.Response.IsSuccessStatusCode)
                Console.WriteLine("[Edit lesson] Successfully edited lesson");
            else
                Console.WriteLine("[Edit lesson] Couldn't edit lesson");
        }

        public async Task ExecuteDeleteLesson()
        {
            Console.WriteLine("Delete lesson example");

            using var programmesClient = new KMDStudicaProgrammes(new TokenCredentials(tokenProvider));
            programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
                ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
                : new Uri(configuration.ProgrammesBaseUri);

            var result = await programmesClient.DeleteLessonExternal.PostWithHttpMessagesAsync(
                body: new DeleteLessonExternalCommand(
                    id: Guid.NewGuid(),
                    subjectCourseId: Guid.NewGuid(),
                    schoolCode: configuration.SchoolCode),
                customHeaders: new Dictionary<string, List<string>>
                {
                    { "Logic-Api-Key", new List<string> { configuration.StudicaExternalApiKey } }
                });

            if (result.Response.IsSuccessStatusCode)
                Console.WriteLine("[Delete lesson] Successfully delete lesson");
            else
                Console.WriteLine("[Delete lesson] Couldn't delete lesson");
        }

        public async Task ExecuteDeleteLessons()
        {
            Console.WriteLine("Delete lessons example");

            using var programmesClient = new KMDStudicaProgrammes(new TokenCredentials(tokenProvider));
            programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
                ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
                : new Uri(configuration.ProgrammesBaseUri);

            var result = await programmesClient.DeleteLessonsExternal.PostWithHttpMessagesAsync(
                body: new DeleteLessonsExternalCommand(
                    ids: new[] { Guid.NewGuid() },
                    subjectCourseId: Guid.NewGuid(),
                    schoolCode: configuration.SchoolCode),
                customHeaders: new Dictionary<string, List<string>>
                {
                    { "Logic-Api-Key", new List<string> { configuration.StudicaExternalApiKey } }
                });

            if (result.Response.IsSuccessStatusCode)
                Console.WriteLine("[Delete lesson] Successfully delete lessons");
            else
                Console.WriteLine("[Delete lesson] Couldn't delete lessons");
        }

        public async Task ExecuteGetBulk()
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