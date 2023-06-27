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
    private readonly AppConfiguration _configuration;

    public InternshipDkExample(ITokenProvider tokenProvider, AppConfiguration configuration)
    {
        _tokenProvider = tokenProvider;
        _configuration = configuration;
    }

    public async Task Execute()
    {
        Console.WriteLine("Get educational agreements example");

        using var internshipDkClient = new KMDStudicaInternshipDK(new TokenCredentials(_tokenProvider));
        internshipDkClient.BaseUri = string.IsNullOrEmpty(_configuration.InternshipDkBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/internship-dk/v1")
            : new Uri(_configuration.InternshipDkBaseUri);

        var result = await internshipDkClient.AgreementsExternal.PostWithHttpMessagesAsync(
            new List<Guid>
            {
                Guid.NewGuid()
            },
            schoolCode: _configuration.SchoolCode,
            customHeaders: new Dictionary<string, List<string>>
            {
                { "Logic-Api-Key", new List<string> { _configuration.StudicaExternalApiKey } }
            });

        Console.WriteLine($"Got {result.Body.Count} agreements from API");

        ConsoleTable
            .From(result.Body)
            .Write();
    }
}
