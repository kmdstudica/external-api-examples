using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ConsoleTables;
using Kmd.Studica.SchoolAdministration.Client;
using Microsoft.Rest;

namespace ExternalApiExamples;

public class RoomsExample
{
    private readonly ITokenProvider tokenProvider;
    private readonly AppConfiguration configuration;

    public RoomsExample(ITokenProvider tokenProvider, AppConfiguration configuration)
    {
        this.tokenProvider = tokenProvider;
        this.configuration = configuration;
    }

    public async Task Execute()
    {
        Console.WriteLine("Executing rooms example");

        using var schoolAdministrationClient = new StudicaDemoSchoolAdministration(new TokenCredentials(tokenProvider));
        schoolAdministrationClient.BaseUri = string.IsNullOrEmpty(configuration.SchoolAdministrationBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/school-administration/v1")
            : new Uri(configuration.SchoolAdministrationBaseUri);

        var result = await schoolAdministrationClient.RoomsExternal.GetWithHttpMessagesAsync(
            schoolCode: configuration.SchoolCode,
            pageNumber: 1,
            pageSize: 1000,
            inlineCount: true,
            customHeaders: new Dictionary<string, List<string>>
            {
                { configuration.ApiKeyName, new List<string> { configuration.StudicaExternalApiKey } }
            });

        Console.WriteLine($"Got {result.Body.TotalItems} rooms from API");
        ConsoleTable
            .From(result.Body.Items)
            .Write();
    }

    public async Task ExecuteBulk()
    {
        Console.WriteLine("Executing bulk rooms example");

        using var schoolAdministrationClient = new StudicaDemoSchoolAdministration(new TokenCredentials(tokenProvider));
        schoolAdministrationClient.BaseUri = string.IsNullOrEmpty(configuration.SchoolAdministrationBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/school-administration/v1")
            : new Uri(configuration.SchoolAdministrationBaseUri);

        var result = await schoolAdministrationClient.BulkRoomsExternal.PostWithHttpMessagesAsync(
            roomIds: new[] { Guid.NewGuid() },
            schoolCode: configuration.SchoolCode,
            customHeaders: new Dictionary<string, List<string>>
            {
                { configuration.ApiKeyName, new List<string> { configuration.StudicaExternalApiKey } }
            });

        Console.WriteLine($"Got {result.Body.Count} rooms from API");

        ConsoleTable
            .From(result.Body)
            .Write();
    }
}
