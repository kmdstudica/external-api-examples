using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ConsoleTables;
using Kmd.Studica.Programmes.Client;
using Microsoft.Rest;

namespace ExternalApiExamples;

public class BridgingCoursesExample
{
    private readonly ITokenProvider tokenProvider;
    private readonly AppConfiguration configuration;

    public BridgingCoursesExample(ITokenProvider tokenProvider, AppConfiguration configuration)
    {
        this.tokenProvider = tokenProvider;
        this.configuration = configuration;
    }

    public async Task ExecuteBridgingCourseStudents()
    {
        Console.Write("Executing bridging course students example");

        using var programmesClient = new KMDStudicaProgrammes(new TokenCredentials(tokenProvider));
        programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
            : new Uri(configuration.ProgrammesBaseUri);

        var result = await programmesClient.BulkBridgingCourseStudentsExternal.PostWithHttpMessagesAsync(
            studentIds: new List<Guid> { Guid.NewGuid() },
            schoolCode: configuration.SchoolCode,
            customHeaders: new Dictionary<string, List<string>>
            {
                {configuration.ApiKeyName, new List<string> {configuration.StudicaExternalApiKey}}
            });

        ConsoleTable
            .From(result.Body)
            .Write();
    }

    public async Task ExecuteActiveBridgingCourses()
    {
        Console.Write("Executing active bridging courses example");

        using var programmesClient = new KMDStudicaProgrammes(new TokenCredentials(tokenProvider));
        programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
            : new Uri(configuration.ProgrammesBaseUri);

        var result = await programmesClient.ActiveBridgingCoursesExternal.GetWithHttpMessagesAsync(
            bridgingCoursesActiveOnOrAfterDate: DateTime.Today, 
            pageNumber: 1,
            pageSize: 100,
            inlineCount: true,
            schoolCode: configuration.SchoolCode,
            customHeaders: new Dictionary<string, List<string>>
            {
                {configuration.ApiKeyName, new List<string> {configuration.StudicaExternalApiKey}}
            });

        Console.WriteLine($"There is a total of {result.Body.TotalItems} bridging courses active on or after {DateTime.Today}");

        ConsoleTable
            .From(result.Body.Items)
            .Write();
    }
}
