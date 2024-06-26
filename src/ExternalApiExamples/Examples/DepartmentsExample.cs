using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ConsoleTables;
using Kmd.Studica.SchoolAdministration.Client;
using Microsoft.Rest;

namespace ExternalApiExamples;

public class DepartmentsExample
{
    private readonly ITokenProvider tokenProvider;
    private readonly AppConfiguration configuration;

    public DepartmentsExample(ITokenProvider tokenProvider, AppConfiguration configuration)
    {
        this.tokenProvider = tokenProvider;
        this.configuration = configuration;
    }

    public async Task Execute()
    {
        Console.WriteLine("Executing departments example");

        using var schoolAdministrationClient = new StudicaDemoSchoolAdministration(new TokenCredentials(tokenProvider));
        schoolAdministrationClient.BaseUri = string.IsNullOrEmpty(configuration.SchoolAdministrationBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/school-administration/v1")
            : new Uri(configuration.SchoolAdministrationBaseUri);

        var result = await schoolAdministrationClient.DepartmentsExternal.GetWithHttpMessagesAsync(
            validFrom: DateTime.Now.AddDays(-10),
            validTo: DateTime.Now.AddDays(10),
            schoolCode: configuration.SchoolCode,
            pageNumber: 1,
            pageSize: 10,
            inlineCount: true,
            customHeaders: new Dictionary<string, List<string>>
            {
                { configuration.ApiKeyName, new List<string> { configuration.StudicaExternalApiKey } }
            });

        Console.WriteLine($"Got {result.Body.TotalItems} departments from API");

        ConsoleTable
            .From(result.Body.Items)
            .Write();
    }

    public async Task ExecuteActive()
    {
        Console.WriteLine("Executing active departments example");

        using var schoolAdministrationClient = new StudicaDemoSchoolAdministration(new TokenCredentials(tokenProvider));
        schoolAdministrationClient.BaseUri = string.IsNullOrEmpty(configuration.SchoolAdministrationBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/school-administration/v1")
            : new Uri(configuration.SchoolAdministrationBaseUri);

        var result = await schoolAdministrationClient.ActiveDepartmentsExternal.GetWithHttpMessagesAsync(
            schoolCode: configuration.SchoolCode,
            pageNumber: 1,
            pageSize: 10,
            inlineCount: true,
            customHeaders: new Dictionary<string, List<string>>
            {
                { configuration.ApiKeyName, new List<string> { configuration.StudicaExternalApiKey } }
            });

        Console.WriteLine($"Got {result.Body.TotalItems} departments from API");

        ConsoleTable
            .From(result.Body.Items)
            .Write();
    }

    public async Task ExecuteBulk()
    {
        Console.WriteLine("Executing bulk departments example");

        using var schoolAdministrationClient = new StudicaDemoSchoolAdministration(new TokenCredentials(tokenProvider));
        schoolAdministrationClient.BaseUri = string.IsNullOrEmpty(configuration.SchoolAdministrationBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/school-administration/v1")
            : new Uri(configuration.SchoolAdministrationBaseUri);

        var result = await schoolAdministrationClient.BulkDepartmentsExternal.PostWithHttpMessagesAsync(
            departmentIds: new[] { Guid.NewGuid() },
            schoolCode: configuration.SchoolCode,
            customHeaders: new Dictionary<string, List<string>>
            {
                { configuration.ApiKeyName, new List<string> { configuration.StudicaExternalApiKey } }
            });

        Console.WriteLine($"Got {result.Body} departments from API");

        ConsoleTable
            .From(result.Body)
            .Write();
    }
}
