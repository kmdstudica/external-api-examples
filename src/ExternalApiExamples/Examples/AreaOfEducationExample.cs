﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ConsoleTables;
using Kmd.Studica.SchoolAdministration.Client;
using Microsoft.Rest;

namespace ExternalApiExamples;

public class AreaOfEducationExample
{
    private readonly ITokenProvider tokenProvider;
    private readonly AppConfiguration configuration;

    public AreaOfEducationExample(ITokenProvider tokenProvider, AppConfiguration configuration)
    {
        this.tokenProvider = tokenProvider;
        this.configuration = configuration;
    }

    public async Task Execute()
    {
        Console.WriteLine("Executing areas of education example");

        using var schoolAdministrationClient = new StudicaDemoSchoolAdministration(new TokenCredentials(tokenProvider));
        schoolAdministrationClient.BaseUri = string.IsNullOrEmpty(configuration.SchoolAdministrationBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/school-administration/v1")
            : new Uri(configuration.SchoolAdministrationBaseUri);

        var result = await schoolAdministrationClient.AreasOfEducationExternal.GetWithHttpMessagesAsync(
            schoolCode: configuration.SchoolCode,
            pageNumber: 1,
            pageSize: 1000,
            inlineCount: true,
            customHeaders: new Dictionary<string, List<string>>
            {
                { configuration.ApiKeyName, new List<string> { configuration.StudicaExternalApiKey } }
            });

        Console.WriteLine($"Got {result.Body.TotalItems} areas from query");

        ConsoleTable
            .From(result.Body.Items)
            .Write();
    }
}
