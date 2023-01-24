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
        programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
            : new Uri(configuration.ProgrammesBaseUri);

        var result = await programmesClient.GroupsExternal.PostWithHttpMessagesAsync(
            new GroupsExternalRequest
            {
                // At least one parameter must be specified
                GroupIds = new List<Guid>()
                {
                    Guid.Parse("42e0df47-c49b-4d25-8c9d-82ea2aaac882"),
                    Guid.Parse("e0845250-62f6-4019-80a3-d19921b7c6d3"),
                    Guid.Parse("2f097e1d-328e-41b7-ae1e-f6b03b885f6c"),
                    Guid.Parse("1210bea5-5751-42c2-bb3f-81a40ff76260"),
                    Guid.Parse("4831db5e-89a3-4020-9443-a81c9050b814"),
                    Guid.Parse("a3930e10-986a-4328-bdee-ba22ebf90466"),
                    Guid.Parse("63e8dc2e-c810-4187-a016-843a74d0b3d5")
                },
                // GroupEntityTypes = new List<string>() { GroupEntityType.SubjectCourse },
                // GroupsActiveOnOrAfterDate = DateTime.Today,
                SchoolCode = configuration.SchoolCode,
            },
            customHeaders: new Dictionary<string, List<string>>
            {
                { "Logic-Api-Key", new List<string> { configuration.StudicaExternalApiKey } }
            });

        Console.WriteLine($"Got {result.Body.Count} rooms from API");

        ConsoleTable
            .From(result.Body)
            .Write();
    }

    private static class GroupEntityType
    {
        public const string SubjectCourse = "SubjectCourse";
    }
}