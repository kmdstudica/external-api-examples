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

    public async Task Execute()
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
                {"Logic-Api-Key", new List<string> {configuration.StudicaExternalApiKey}}
            });

        ConsoleTable
            .From(result.Body)
            .Write();
    }
}