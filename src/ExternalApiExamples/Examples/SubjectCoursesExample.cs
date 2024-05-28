using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ConsoleTables;
using Kmd.Studica.Programmes.Client;
using Kmd.Studica.Programmes.Client.Models;
using Microsoft.Rest;

namespace ExternalApiExamples;

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

        bool doContinue;
        var pageNum = 0;
        var pageSize = 100;
        var courses = new List<SubjectCourseExternalResponse>();
        do
        {
            var result = await programmesClient.SubjectCoursesExternal.GetWithHttpMessagesAsync(
                startDateFrom: DateTime.Today,
                startDateTo: DateTime.Today.AddMonths(6),
                includeDeletedSubjectCourses: false,
                schoolCode: configuration.SchoolCode,
                pageNumber: ++pageNum,
                pageSize: pageSize,
                inlineCount: true,
                customHeaders: new Dictionary<string, List<string>>
                {
                    { configuration.ApiKeyName, new List<string> { configuration.StudicaExternalApiKey } }
                });

            if (pageNum == 1)
            {
                Console.WriteLine($"Reading {result.Body.TotalItems} course elements");
            }

            courses.AddRange(result.Body.Items);

            Console.Write(".");

            doContinue = pageNum * pageSize < result.Body.TotalItems;
        } while (doContinue);

        Console.WriteLine($"Got {courses.Count} subject courses from API");

        ConsoleTable
            .From(courses)
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
                { configuration.ApiKeyName, new List<string> { configuration.StudicaExternalApiKey } }
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
            studentIds: new[] { Guid.NewGuid() },
            pageNumber: 1,
            pageSize: 100,
            inlineCount: true,
            schoolCode: configuration.SchoolCode,
            customHeaders: new Dictionary<string, List<string>>
            {
                { configuration.ApiKeyName, new List<string> { configuration.StudicaExternalApiKey } }
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
            includeDeletedSubjectCourses: false,
            schoolCode: configuration.SchoolCode,
            pageNumber: 1,
            pageSize: 100,
            inlineCount: true,
            customHeaders: new Dictionary<string, List<string>>
            {
                { configuration.ApiKeyName, new List<string> { configuration.StudicaExternalApiKey } }
            });

        Console.WriteLine($"Got {result.Body.TotalItems} subject courses from API");

        ConsoleTable
            .From(result.Body.Items)
            .Write();
    }
}
