using System.Threading.Tasks;
using Microsoft.Rest;

namespace ExternalApiExamples;
#pragma warning disable CS1998
/// <summary>
/// Notice:
/// The Lessons services will become deprecated in a future release.
/// Please use the Sesssions services instead
/// </summary>
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
        // #warning Method deprecated
        // Console.WriteLine("Lessons example");
        //
        // using var programmesClient = new KMDStudicaProgrammes(new TokenCredentials(tokenProvider));
        // programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
        //     ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
        //     : new Uri(configuration.ProgrammesBaseUri);
        //
        // HttpOperationResponse<PagedResponseLessonExternalResponse> result =
        //     await programmesClient.LessonsExternal.GetWithHttpMessagesAsync(
        //         dateFrom: new DateTime(2022, 12, 12),
        //         dateTo: new DateTime(2022, 12, 12),
        //         schoolCode: configuration.SchoolCode,
        //         pageNumber: 1,
        //         pageSize: 1000,
        //         inlineCount: true,
        //         customHeaders: new Dictionary<string, List<string>>
        //         {
        //                 {"Logic-Api-Key", new List<string> {configuration.StudicaExternalApiKey}}
        //         });
        //
        // Console.WriteLine($"Got {result.Body.TotalItems} lessons from API");
        //
        // ConsoleTable
        //     .From(result.Body.Items)
        //     .Write();
    }

    public async Task ExecuteGetUnscheduled()
    {
        // #warning Method deprecated
        // Console.WriteLine("Get unscheduled lessons example");
        //
        // using var programmesClient = new KMDStudicaProgrammes(new TokenCredentials(tokenProvider));
        // programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
        //     ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
        //     : new Uri(configuration.ProgrammesBaseUri);
        //
        // var result = await programmesClient.UnscheduledLessonsExternal.GetWithHttpMessagesAsync(
        //     schoolCode: configuration.SchoolCode,
        //     pageNumber: 1,
        //     pageSize: 10,
        //     inlineCount: true,
        //     customHeaders: new Dictionary<string, List<string>>
        //     {
        //         { "Logic-Api-Key", new List<string> { configuration.StudicaExternalApiKey } }
        //     });
        //
        // Console.WriteLine($"Got {result.Body.TotalItems} lessons from API");
        //
        // ConsoleTable
        //     .From(result.Body.Items)
        //     .Write();
    }

    public async Task ExecuteAddLessons()
    {
        // #warning Method deprecated
        // Console.WriteLine("Add lessons example");
        //
        // using var programmesClient = new KMDStudicaProgrammes(new TokenCredentials(tokenProvider));
        // programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
        //     ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
        //     : new Uri(configuration.ProgrammesBaseUri);
        //
        // var result = await programmesClient.AddLessonsExternal.PostWithHttpMessagesAsync(
        //     newLessons: new[]
        //     {
        //         new NewLessonExternal
        //         {
        //             Id = Guid.NewGuid(),
        //             ExternalLessonId = "external id 1",
        //             SubjectCourseId = Guid.NewGuid(),
        //             StartTime = "11:15",
        //             EndTime = "12:00",
        //             Date = DateTime.Now,
        //             RoomIds = new[] { Guid.NewGuid() },
        //             TeacherIds = new[] { Guid.NewGuid() },
        //         }
        //     },
        //     schoolCode: configuration.SchoolCode,
        //     customHeaders: new Dictionary<string, List<string>>
        //     {
        //         { "Logic-Api-Key", new List<string> { configuration.StudicaExternalApiKey } }
        //     });
        //
        // if (result.Response.IsSuccessStatusCode)
        //     Console.WriteLine("[Add lesson] Successfully added new lessons");
        // else
        //     Console.WriteLine("[Add lesson] Couldn't add new lessons");
    }

    public async Task ExecuteEditLesson()
    {
        // #warning Method deprecated
        // Console.WriteLine("Edit lesson example");
        //
        // using var programmesClient = new KMDStudicaProgrammes(new TokenCredentials(tokenProvider));
        // programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
        //     ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
        //     : new Uri(configuration.ProgrammesBaseUri);
        //
        // var result = await programmesClient.EditLessonExternal.PostWithHttpMessagesAsync(
        //     body: new EditLessonExternalCommand(
        //         id: Guid.NewGuid(),
        //         subjectCourseId: Guid.NewGuid(),
        //         roomIds: new[] { Guid.NewGuid() },
        //         date: DateTime.Now,
        //         startTime: "11:15",
        //         endTime: "12:00",
        //         teacherIds: new[] { Guid.NewGuid() },
        //         schoolCode: configuration.SchoolCode),
        //     customHeaders: new Dictionary<string, List<string>>
        //     {
        //         { "Logic-Api-Key", new List<string> { configuration.StudicaExternalApiKey } }
        //     });
        //
        // if (result.Response.IsSuccessStatusCode)
        //     Console.WriteLine("[Edit lesson] Successfully edited lesson");
        // else
        //     Console.WriteLine("[Edit lesson] Couldn't edit lesson");
    }

    public async Task ExecuteDeleteLesson()
    {
        // #warning Method deprecated
        // Console.WriteLine("Delete lesson example");
        //
        // using var programmesClient = new KMDStudicaProgrammes(new TokenCredentials(tokenProvider));
        // programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
        //     ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
        //     : new Uri(configuration.ProgrammesBaseUri);
        //
        // var result = await programmesClient.DeleteLessonExternal.PostWithHttpMessagesAsync(
        //     body: new DeleteLessonExternalCommand(
        //         id: Guid.NewGuid(),
        //         subjectCourseId: Guid.NewGuid(),
        //         schoolCode: configuration.SchoolCode),
        //     customHeaders: new Dictionary<string, List<string>>
        //     {
        //         { "Logic-Api-Key", new List<string> { configuration.StudicaExternalApiKey } }
        //     });
        //
        // if (result.Response.IsSuccessStatusCode)
        //     Console.WriteLine("[Delete lesson] Successfully delete lesson");
        // else
        //     Console.WriteLine("[Delete lesson] Couldn't delete lesson");
    }

    public async Task ExecuteDeleteLessons()
    {
        // #warning Method deprecated
        // Console.WriteLine("Delete lessons example");
        //
        // using var programmesClient = new KMDStudicaProgrammes(new TokenCredentials(tokenProvider));
        // programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
        //     ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
        //     : new Uri(configuration.ProgrammesBaseUri);
        //
        // var result = await programmesClient.DeleteLessonsExternal.PostWithHttpMessagesAsync(
        //     body: new DeleteLessonsExternalCommand(
        //         ids: new[] { Guid.NewGuid() },
        //         subjectCourseId: Guid.NewGuid(),
        //         schoolCode: configuration.SchoolCode),
        //     customHeaders: new Dictionary<string, List<string>>
        //     {
        //         { "Logic-Api-Key", new List<string> { configuration.StudicaExternalApiKey } }
        //     });
        //
        // if (result.Response.IsSuccessStatusCode)
        //     Console.WriteLine("[Delete lesson] Successfully delete lessons");
        // else
        //     Console.WriteLine("[Delete lesson] Couldn't delete lessons");
    }

    public async Task ExecuteGetBulk()
    {
        // #warning Method deprecated
        // Console.WriteLine("Bulk lessons example");
        //
        // using var programmesClient = new KMDStudicaProgrammes(new TokenCredentials(tokenProvider));
        // programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
        //     ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
        //     : new Uri(configuration.ProgrammesBaseUri);
        //
        // var result = await programmesClient.BulkLessonsExternal.PostWithHttpMessagesAsync(
        //     lessonIds: new[] { Guid.NewGuid() },
        //     schoolCode: configuration.SchoolCode,
        //     customHeaders: new Dictionary<string, List<string>>
        //     {
        //         { "Logic-Api-Key", new List<string> { configuration.StudicaExternalApiKey } }
        //     });
        //
        // Console.WriteLine($"Got {result.Body.Count} lessons from API");
        //
        // ConsoleTable
        //     .From(result.Body)
        //     .Write();
    }
}
#pragma warning restore CS1998