﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ConsoleTables;
using Kmd.Studica.Programmes.Client;
using Kmd.Studica.Programmes.Client.Models;
using Microsoft.Rest;

namespace ExternalApiExamples;

public class EducationalProgrammesExample
{
    private readonly ITokenProvider tokenProvider;
    private readonly AppConfiguration configuration;

    public EducationalProgrammesExample(ITokenProvider tokenProvider, AppConfiguration configuration)
    {
        this.tokenProvider = tokenProvider;
        this.configuration = configuration;
    }

    public async Task Execute()
    {
        Console.WriteLine("Executing educational programmes example");

        using var programmesClient = new StudicaDemoProgrammes(new TokenCredentials(tokenProvider));
        programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
            : new Uri(configuration.ProgrammesBaseUri);

        var doContinue = true;
        var pageNum = 0;
        var pageSize = 100;

        var programmes = new List<EducationalProgrammeExternalResponse>();
        do
        {
            var result = await programmesClient.EducationalProgrammesExternal.GetWithHttpMessagesAsync(
                startDateFrom: DateTime.Today.AddYears(-1),
                startDateTo: DateTime.Today.AddYears(1),
                includeDeletedProgrammes: false,
                schoolCode: configuration.SchoolCode,
                pageNumber: ++pageNum,
                pageSize: pageSize,
                inlineCount: true,
                customHeaders: new Dictionary<string, List<string>>
                {
                    {configuration.ApiKeyName, new List<string> {configuration.StudicaExternalApiKey}}
                });
            doContinue = pageNum * pageSize < result.Body.TotalItems;
            programmes.AddRange(result.Body.Items);
            Console.Write(".");
        } while (doContinue);

        Console.WriteLine($"Got {programmes.Count} educational programmes from API");

        ConsoleTable
            .From(programmes)
            .Write();
    }

    public async Task ExecuteBulk()
    {
        Console.WriteLine("Executing bulk educational programmes example");

        using var programmesClient = new StudicaDemoProgrammes(new TokenCredentials(tokenProvider));
        programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
            : new Uri(configuration.ProgrammesBaseUri);

        var result = await programmesClient.BulkEducationalProgrammesExternal.PostWithHttpMessagesAsync(
            educationalProgrammeIds: new[] {Guid.NewGuid()},
            schoolCode: configuration.SchoolCode,
            customHeaders: new Dictionary<string, List<string>>
            {
                {configuration.ApiKeyName, new List<string> {configuration.StudicaExternalApiKey}}
            });

        Console.WriteLine($"Got {result.Body} educational programmes from API");

        ConsoleTable
            .From(result.Body)
            .Write();
    }
}