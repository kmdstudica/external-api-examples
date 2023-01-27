using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ConsoleTables;
using Kmd.Studica.Programmes.Client;
using Kmd.Studica.Programmes.Client.Models;
using Microsoft.Rest;

namespace ExternalApiExamples;

public class GroupsExample
{
    private readonly ITokenProvider tokenProvider;
    private readonly AppConfiguration configuration;

    public GroupsExample(ITokenProvider tokenProvider, AppConfiguration configuration)
    {
        this.tokenProvider = tokenProvider;
        this.configuration = configuration;
    }

    public async Task ExecuteGroups()
    {
        Console.WriteLine("Executing groups example");

        using var programmesClient = new KMDStudicaProgrammes(new TokenCredentials(tokenProvider));
        programmesClient.HttpClient.Timeout = new TimeSpan(0, 0, 10, 0);
        programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
            : new Uri(configuration.ProgrammesBaseUri);

        HttpOperationResponse<IList<GroupsExternalResponse>> result = await programmesClient.GroupsExternal.PostWithHttpMessagesAsync(
            new GroupsExternalRequest
            {
                // At least one parameter must be specified
                GroupIds = null,
                GroupEntityTypes = new List<string>() { GroupEntityType.SubjectCourse },
                IncludeDeletedGroups = false,
                // GroupsActiveOnOrAfterDate = DateTime.Today,
                SchoolCode = configuration.SchoolCode
            },
            customHeaders: new Dictionary<string, List<string>>
            {
                { "Logic-Api-Key", new List<string> { configuration.StudicaExternalApiKey } }
            });

        Console.WriteLine($"Got {result.Body.Count} groups from API");

        ConsoleTable
            .From(result.Body)
            .Write();
    }

    private static class GroupEntityType
    {
        public const string SubjectCourse = "SubjectCourse";
    }
    
    public static class CourseStudentType
    {
        public const string Student = "Student";
        public const string BridgingCourseStudent = "BridgingCourseStudent";
        public const string Employee = "Employee";
        public const string ExternalBoardingFacilityStudent = "ExternalBoardingFacilityStudent";
    }
}