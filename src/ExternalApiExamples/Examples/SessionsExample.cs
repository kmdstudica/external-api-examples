using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ConsoleTables;
using Kmd.Studica.Programmes.Client;
using Kmd.Studica.Programmes.Client.Models;
using Microsoft.Rest;

namespace ExternalApiExamples;

public class SessionsExample
{
    private readonly ITokenProvider tokenProvider;
    private readonly AppConfiguration configuration;

    public SessionsExample(ITokenProvider tokenProvider, AppConfiguration configuration)
    {
        this.tokenProvider = tokenProvider;
        this.configuration = configuration;
    }

    public async Task ExecuteSessions()
    {
        Console.WriteLine("Get sessions example");

        using var programmesClient = new StudicaDemoProgrammes(new TokenCredentials(tokenProvider));
        programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
            : new Uri(configuration.ProgrammesBaseUri);

        var result = await programmesClient.SessionsExternal.GetWithHttpMessagesAsync(
            groupIds: null,
            teacherIds: null,
            roomIds: null,
            dateFrom: DateTime.Today,
            dateTo: DateTime.Today.AddMonths(1),
            schoolCode: configuration.SchoolCode,
            pageNumber: 1,
            pageSize: 10,
            inlineCount: true,
            customHeaders: new Dictionary<string, List<string>>
            {
                { configuration.ApiKeyName, new List<string> { configuration.StudicaExternalApiKey } }
            });

        Console.WriteLine($"Got {result.Body.TotalItems} sessions from API");

        ConsoleTable
            .From(result.Body.Items)
            .Write();
    }

    public async Task ExecuteSessionsById()
    {
        Console.WriteLine("Get sessions by id example");

        using var programmesClient = new StudicaDemoProgrammes(new TokenCredentials(tokenProvider));
        programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
            : new Uri(configuration.ProgrammesBaseUri);

        var result = await programmesClient.SessionsByIdExternal.GetWithHttpMessagesAsync(
            new List<Guid>
            {
                Guid.NewGuid()
            },
            schoolCode: configuration.SchoolCode,
            customHeaders: new Dictionary<string, List<string>>
            {
                { configuration.ApiKeyName, new List<string> { configuration.StudicaExternalApiKey } }
            });

        Console.WriteLine($"Got {result.Body.Count} sessions from API");

        ConsoleTable
            .From(result.Body)
            .Write();
    }

    public async Task ExecuteAddSessionsToSubjectCourses()
    {
        Console.WriteLine("Add sessions example");

        using var programmesClient = new StudicaDemoProgrammes(new TokenCredentials(tokenProvider));
        programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
            : new Uri(configuration.ProgrammesBaseUri);

        var sessionId1 = Guid.NewGuid();
        var result = await programmesClient.AddSessionsToSubjectCoursesExternal.PostWithHttpMessagesAsync(
            new List<ExternalSubjectCourseSessionDto>
            {
                new()
                {
                    SessionId = sessionId1,
                    Comment = "Session comment",
                    ExternalLessonId = sessionId1.ToString(),
                    GroupIds = new List<Guid>
                    {
                        Guid.NewGuid(), // Root group or sub group from SubjectCourse 1
                        Guid.NewGuid() // Root group or sub group from SubjectCourse 2
                    },
                    RoomIds = new List<Guid>
                    {
                        Guid.NewGuid(), // Room 1 
                        Guid.NewGuid() // Room 2
                    },
                    TeacherIds = new List<Guid>
                    {
                        Guid.NewGuid(), // Teacher 1
                        Guid.NewGuid() // Teacher 2
                    },

                    SchoolHourEntryId = Guid.NewGuid()
                    
                    // Custom time for session - do not use if using school hours, which is preferred
                    // Date = new DateTime(),
                    // StartTime = "08:00",
                    // EndTime = "08:45"
                }
            },
            schoolCode: configuration.SchoolCode,
            customHeaders: new Dictionary<string, List<string>>
            {
                { configuration.ApiKeyName, new List<string> { configuration.StudicaExternalApiKey } }
            });

        if (result.Response.IsSuccessStatusCode)
            Console.WriteLine("Sessions added");
        else
            Console.WriteLine("Could not add sessions");
    }

    public async Task ExecuteDeleteSessions()
    {
        Console.WriteLine("Delete sessions example");

        using var programmesClient = new StudicaDemoProgrammes(new TokenCredentials(tokenProvider));
        programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
            : new Uri(configuration.ProgrammesBaseUri);

        var result = await programmesClient.DeleteSessionsExternal.PostWithHttpMessagesAsync(
            sessionIds: new List<Guid>
            {
                Guid.NewGuid(),
                Guid.NewGuid()
            },
            schoolCode: configuration.SchoolCode,
            customHeaders: new Dictionary<string, List<string>>
            {
                { configuration.ApiKeyName, new List<string> { configuration.StudicaExternalApiKey } }
            });

        if (result.Response.IsSuccessStatusCode)
            Console.WriteLine("Sessions deleted");
        else
            Console.WriteLine("Could not deleted sessions");
    }

    public async Task ExecuteEditSubjectCourseSession()
    {
        Console.WriteLine("Edit subject course session example");

        using var programmesClient = new StudicaDemoProgrammes(new TokenCredentials(tokenProvider));
        programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
            : new Uri(configuration.ProgrammesBaseUri);

        var sessionId = Guid.NewGuid();
        var result = await programmesClient.EditSubjectCourseSessionExternal.PostWithHttpMessagesAsync(
            new EditSubjectCourseSessionExternalCommand
            {
                SessionId = sessionId,
                Comment = "Session comment",
                ExternalLessonId = sessionId.ToString(),
                GroupIds = new List<Guid>
                {
                    Guid.NewGuid(), // Root group or sub group from SubjectCourse 1
                    Guid.NewGuid() // Root group or sub group from SubjectCourse 2
                },
                RoomIds = new List<Guid>
                {
                    Guid.NewGuid(), // Room 1 
                    Guid.NewGuid() // Room 2
                },
                TeacherIds = new List<Guid>
                {
                    Guid.NewGuid(), // Teacher 1
                    Guid.NewGuid() // Teacher 2
                },

                SchoolHourEntryId = Guid.NewGuid()
                
                // Custom time for session - do not use if using school hours, which is preferred
                // Date = new DateTime(),
                // StartTime = "08:00",
                // EndTime = "08:45"
            },
            customHeaders: new Dictionary<string, List<string>>
            {
                { configuration.ApiKeyName, new List<string> { configuration.StudicaExternalApiKey } }
            });

        if (result.Response.IsSuccessStatusCode)
            Console.WriteLine("Session modified");
        else
            Console.WriteLine("Could not modify session");
    }

    public async Task ExecuteAddExtracurricularSessions()
    {
        Console.WriteLine("Add extra curricular sessions example");

        using var programmesClient = new StudicaDemoProgrammes(new TokenCredentials(tokenProvider));
        programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
            : new Uri(configuration.ProgrammesBaseUri);

        var sessionId = Guid.NewGuid();
        var result = await programmesClient.AddExtracurricularSessionsExternal.PostWithHttpMessagesAsync(
            new List<ExternalExtracurricularSessionDto>
            {
                new()
                {
                    SessionId = sessionId,
                    Title = "Session title",
                    Description = "Extra curricular session comment",
                    ExternalLessonId = sessionId.ToString(),
                    GroupIds = new List<Guid>
                    {
                        Guid.NewGuid(), // E.g. root group or sub group from educational programme
                        Guid.NewGuid() // E.g. group of students
                    },
                    RoomIds = new List<Guid>
                    {
                        Guid.NewGuid(), // Room 1 
                        Guid.NewGuid() // Room 2
                    },
                    EmployeeIds = new List<Guid>
                    {
                        Guid.NewGuid(), // Teacher 1
                        Guid.NewGuid() // Teacher 2
                    },

                    SchoolHourEntryId = Guid.NewGuid(),
                
                    // Custom time for session - do not use if using school hours, which is preferred
                    // Date = new DateTime(),
                    // StartTime = "08:00",
                    // EndTime = "08:45",
                    
                    IsMandatory = false,
                    IsPrivate = false,
                    SessionEntityType = SessionEntityType.Social,
                    RecurrenceId = Guid.NewGuid() // Not yet used, but will be used for identifying recurring sessions in the future
                }
            },
            schoolCode: configuration.SchoolCode,
            customHeaders: new Dictionary<string, List<string>>
            {
                { configuration.ApiKeyName, new List<string> { configuration.StudicaExternalApiKey } }
            });

        if (result.Response.IsSuccessStatusCode)
            Console.WriteLine("Sessions added");
        else
            Console.WriteLine("Could not add sessions");
    }

    public async Task ExecuteEditExtracurricularSessions()
    {
        Console.WriteLine("Edit extra curricular sessions example");

        using var programmesClient = new StudicaDemoProgrammes(new TokenCredentials(tokenProvider));
        programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
            : new Uri(configuration.ProgrammesBaseUri);

        var sessionId = Guid.NewGuid();
        var result = await programmesClient.EditExtracurricularSessionExternal.PostWithHttpMessagesAsync(
            new EditExtracurricularSessionExternalCommand
            {
                SessionId = sessionId,
                Title = "Session title",
                Description = "Extra curricular session comment",
                ExternalLessonId = sessionId.ToString(),
                GroupIds = new List<Guid>
                {
                    Guid.NewGuid(), // E.g. root group or sub group from educational programme
                    Guid.NewGuid() // E.g. group of students
                },
                RoomIds = new List<Guid>
                {
                    Guid.NewGuid(), // Room 1 
                    Guid.NewGuid() // Room 2
                },
                EmployeeIds = new List<Guid>
                {
                    Guid.NewGuid(), // Teacher 1
                    Guid.NewGuid() // Teacher 2
                },
                
                SchoolHourEntryId = Guid.NewGuid(),
                
                // Custom time for session - do not use if using school hours, which is preferred
                // Date = new DateTime(),
                // StartTime = "08:00",
                // EndTime = "08:45",

                IsMandatory = false,
                IsPrivate = false
            },
            customHeaders: new Dictionary<string, List<string>>
            {
                { configuration.ApiKeyName, new List<string> { configuration.StudicaExternalApiKey } }
            });

        if (result.Response.IsSuccessStatusCode)
            Console.WriteLine("Session modified");
        else
            Console.WriteLine("Could not modify session");
    }
    
    private static class SessionEntityType
    {
        public const string None = "None";
        public const string SubjectCourse = "SubjectCourse";
        public const string EducationalProgramme = "EducationalProgramme";
        public const string PrivateAbsence = "PrivateAbsence";
        public const string Meeting = "Meeting";
        public const string Social = "Social";
        public const string Other = "Other";
    }
}
