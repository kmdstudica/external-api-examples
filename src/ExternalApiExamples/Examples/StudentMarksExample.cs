using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ConsoleTables;
using Kmd.Studica.Students.Client;
using Microsoft.Rest;

namespace ExternalApiExamples;

public class StudentMarksExample
{
    private readonly ITokenProvider tokenProvider;
    private readonly AppConfiguration configuration;

    public StudentMarksExample(ITokenProvider tokenProvider, AppConfiguration configuration)
    {
        this.tokenProvider = tokenProvider;
        this.configuration = configuration;
    }

    public async Task Execute()
    {
        Console.WriteLine("Executing student marks example");

        using var studentsClient = new KMDStudicaStudents(new TokenCredentials(tokenProvider));
        studentsClient.BaseUri = string.IsNullOrEmpty(configuration.StudentsBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/students/v1")
            : new Uri(configuration.StudentsBaseUri);

        var result = await studentsClient.StudentMarksExternal.GetWithHttpMessagesAsync(
            studentIds: new[] { Guid.NewGuid() },
            onlyIncludeMarksForExamPaper: false,
            schoolCode: configuration.SchoolCode,
            pageNumber: 1,
            pageSize: 10,
            inlineCount: true,
            customHeaders: new Dictionary<string, List<string>>
            {
                { configuration.ApiKeyName, new List<string> { configuration.StudicaExternalApiKey } }
            });

        Console.WriteLine($"Got {result.Body.TotalItems} student marks from API");

        ConsoleTable
            .From(result.Body.Items)
            .Write();
    }

}
