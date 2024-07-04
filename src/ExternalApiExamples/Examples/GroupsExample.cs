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

        using var programmesClient = new StudicaDemoProgrammes(new TokenCredentials(tokenProvider));
        programmesClient.HttpClient.Timeout = new TimeSpan(0, 0, 10, 0);
        programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
            : new Uri(configuration.ProgrammesBaseUri);

        HttpOperationResponse<IList<GroupsExternalResponse>> result = await programmesClient.GroupsExternal.PostWithHttpMessagesAsync(
            new GroupsExternalRequest
            {
                // At least one parameter must be specified
                
                // Either group ids
                // GroupIds = new List<Guid>
                // {
                //     new Guid("")
                // },
                
                // Alternatively, leave GroupIds empty and specify other parameters
                GroupEntityTypes = new List<string>() { GroupEntityType.SubjectCourse },
                IncludeDeletedGroups = true,
                GroupsActiveOnOrAfterDate = DateTime.Today.AddMonths(-6),
                SchoolCode = configuration.SchoolCode
            },
            customHeaders: new Dictionary<string, List<string>>
            {
                { configuration.ApiKeyName, new List<string> { configuration.StudicaExternalApiKey } }
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
}