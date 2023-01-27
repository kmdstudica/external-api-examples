using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ConsoleTables;
using Kmd.Studica.Students.Client;
using Microsoft.Rest;

namespace ExternalApiExamples;

public class StudentsExample
{
    private readonly ITokenProvider tokenProvider;
    private readonly AppConfiguration configuration;

    public StudentsExample(ITokenProvider tokenProvider, AppConfiguration configuration)
    {
        this.tokenProvider = tokenProvider;
        this.configuration = configuration;
    }

    public async Task Execute()
    {
        Console.Write("Executing student example");

        using var studentsClient = new KMDStudicaStudents(new TokenCredentials(tokenProvider));
        studentsClient.BaseUri = string.IsNullOrEmpty(configuration.StudentsBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/students/v1")
            : new Uri(configuration.StudentsBaseUri);

        var result = await studentsClient.ActiveStudentsExternal.GetWithHttpMessagesAsync(
            studentActiveOnOrAfterDate: new DateTime(DateTime.Today.Year - 1, 08, 01),
            schoolCode: configuration.SchoolCode,
            pageNumber: 1,
            pageSize: 100,
            inlineCount: true,
            customHeaders: new Dictionary<string, List<string>>
            {
                {"Logic-Api-Key", new List<string> {configuration.StudicaExternalApiKey}}
            });


        Console.WriteLine($"Got {result.Body.TotalItems} students from API");
        ConsoleTable
            .From(result.Body.Items)
            .Write();

    }

    public async Task ExecuteBulk()
    {
        Console.WriteLine("Executing bulk student example");

        using var studentsClient = new KMDStudicaStudents(new TokenCredentials(tokenProvider));
        studentsClient.BaseUri = string.IsNullOrEmpty(configuration.StudentsBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/students/v1")
            : new Uri(configuration.StudentsBaseUri);

        var result = await studentsClient.BulkStudentsExternal.PostWithHttpMessagesAsync(
            studentIds: new[] { Guid.NewGuid() },
            schoolCode: configuration.SchoolCode,
            customHeaders: new Dictionary<string, List<string>>
            {
                {"Logic-Api-Key", new List<string> {configuration.StudicaExternalApiKey}}
            });

        Console.WriteLine($"Got {result.Body.Count} students from API");

        ConsoleTable
            .From(result.Body)
            .Write();
    }
}