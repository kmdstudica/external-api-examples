using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ConsoleTables;
using Kmd.Studica.Programmes.Client;
using Kmd.Studica.Programmes.Client.Models;
using Microsoft.Rest;

namespace ExternalApiExamples;

public class LessonAbsencesExample
{
    private readonly ITokenProvider tokenProvider;
    private readonly AppConfiguration configuration;

    public LessonAbsencesExample(ITokenProvider tokenProvider, AppConfiguration configuration)
    {
        this.tokenProvider = tokenProvider;
        this.configuration = configuration;
    }

    public async Task Execute()
    {
        Console.WriteLine("Get absences example");

        using var programmesClient = new StudicaDemoProgrammes(new TokenCredentials(tokenProvider));
        programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
            : new Uri(configuration.ProgrammesBaseUri);

        var result = await programmesClient.AbsenceRegistrationsExternal.GetWithHttpMessagesAsync(
            dateFrom: DateTime.Now.AddMonths(-12),
            dateTo: DateTime.Now.AddMonths(6),
            schoolCode: configuration.SchoolCode,
            pageNumber: 1,
            pageSize: 10,
            inlineCount: true,
            studentId: Guid.NewGuid(),  // optional filter
            lessonId: Guid.NewGuid(),   // optional filter
            customHeaders: new Dictionary<string, List<string>>
            {
                { configuration.ApiKeyName, new List<string> { configuration.StudicaExternalApiKey } }
            });

        Console.WriteLine($"Got {result.Body.TotalItems} absences from API");

        ConsoleTable
            .From(result.Body.Items)
            .Write();
    }

    public async Task ExecuteRegisterAbsence()
    {
        Console.WriteLine("Register absence example");

        using var programmesClient = new StudicaDemoProgrammes(new TokenCredentials(tokenProvider));
        programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
            : new Uri(configuration.ProgrammesBaseUri);

        var result = await programmesClient.RegisterAbsenceExternal.PostWithHttpMessagesAsync(
            new RegisterAbsenceExternalCommand(
                lessonId: Guid.NewGuid(),
                subjectCourseId: Guid.NewGuid(),
                absenceRegistered: true,
                absenceRegistrations: new List<RegisterAbsenceRegistrationDto>
                {
                    new RegisterAbsenceRegistrationDto(
                        studentId: Guid.NewGuid(),
                        status: "Absent",
                        minutes: 34,
                        approved: false,
                        comment: "Custom comment")
                },
                schoolCode: configuration.SchoolCode),
            customHeaders: new Dictionary<string, List<string>>
            {
                { configuration.ApiKeyName, new List<string> { configuration.StudicaExternalApiKey } }
            });

        if (result.Response.IsSuccessStatusCode)
            Console.WriteLine("[Register absence] Successfully registered absence");
        else
            Console.WriteLine("[Register absence] Couldn't register absence");
    }
}
