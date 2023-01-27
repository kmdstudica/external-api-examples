using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ConsoleTables;
using Kmd.Studica.SchoolAdministration.Client;
using Microsoft.Rest;

namespace ExternalApiExamples;

public class DayCalendarsExample
{
    private readonly ITokenProvider tokenProvider;
    private readonly AppConfiguration configuration;

    public DayCalendarsExample(ITokenProvider tokenProvider, AppConfiguration configuration)
    {
        this.tokenProvider = tokenProvider;
        this.configuration = configuration;
    }

    public async Task Execute()
    {
        Console.WriteLine("Executing day calendars example");

        using var schoolAdministrationClient = new KMDStudicaSchoolAdministration(new TokenCredentials(tokenProvider));
        schoolAdministrationClient.BaseUri = string.IsNullOrEmpty(configuration.SchoolAdministrationBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/school-administration/v1")
            : new Uri(configuration.SchoolAdministrationBaseUri);

        var result = await schoolAdministrationClient.DayCalendarsExternal.GetWithHttpMessagesAsync(
            schoolCode: configuration.SchoolCode,
            pageNumber: 1,
            pageSize: 10,
            inlineCount: true,
            customHeaders: new Dictionary<string, List<string>>
            {
                { "Logic-Api-Key", new List<string> { configuration.StudicaExternalApiKey } }
            });

        Console.WriteLine($"Got {result.Body.TotalItems} plans from API");

        ConsoleTable
            .From(result.Body.Items)
            .Write();
    }
}