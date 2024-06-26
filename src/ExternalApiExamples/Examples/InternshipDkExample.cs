using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ConsoleTables;
using Kmd.Studica.InternshipDk.Client;
using Microsoft.Rest;

namespace ExternalApiExamples;

public class InternshipDkExample
{
    private readonly ITokenProvider _tokenProvider;
    private readonly AppConfiguration configuration;

    public InternshipDkExample(ITokenProvider tokenProvider, AppConfiguration configuration)
    {
        _tokenProvider = tokenProvider;
        this.configuration = configuration;
    }

    public async Task Execute()
    {
        Console.WriteLine("Get educational agreements example");

        using var internshipDkClient = new StudicaDemoInternshipDK(new TokenCredentials(_tokenProvider));
        internshipDkClient.BaseUri = string.IsNullOrEmpty(configuration.InternshipDkBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/internship-dk/v1")
            : new Uri(configuration.InternshipDkBaseUri);

        var result = await internshipDkClient.AgreementsExternal.PostWithHttpMessagesAsync(
            new List<Guid>
            {
                Guid.NewGuid()
            },
            schoolCode: configuration.SchoolCode,
            customHeaders: new Dictionary<string, List<string>>
            {
                { configuration.ApiKeyName, new List<string> { configuration.StudicaExternalApiKey } }
            });

        Console.WriteLine($"Got {result.Body.Count} agreements from API");

        ConsoleTable
            .From(result.Body)
            .Write();
    }
}
