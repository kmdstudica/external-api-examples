using ConsoleTables;
using Kmd.Studica.Programmes.Client;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExternalApiExamples
{
    public class EducationalProgrammesExample
    {
        public async Task Execute(ITokenProvider tokenProvider, string apiKey)
        {
            Console.WriteLine("Executing educational programmes example");

            using var programmesClient = new KMDStudicaReviewProgrammes(new TokenCredentials(tokenProvider));
            var result = await programmesClient.EducationalProgrammesExternal.GetWithHttpMessagesAsync(
                startDateFrom: DateTime.Now.AddMonths(-12),
                startDateTo: DateTime.Now.AddMonths(6),
                schoolCode: Configuration.TestSchoolCode,
                pageNumber: 1,
                pageSize: 10,
                inlineCount: true,
                customHeaders: new Dictionary<string, List<string>>
                {
                    { "Logic-Api-Key", new List<string> { apiKey } }
                });

            Console.WriteLine($"Got {result.Body.TotalItems} educational programmes from API");

            ConsoleTable
                .From(result.Body.Items)
                .Write();
        }
    }
}