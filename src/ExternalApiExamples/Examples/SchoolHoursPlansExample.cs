using ConsoleTables;
using Kmd.Studica.SchoolAdministration.Client;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExternalApiExamples
{
    public class SchoolHoursPlansExample
    {
        public async Task Execute(ITokenProvider tokenProvider, string apiKey, string schoolCode)
        {
            Console.WriteLine("Executing school hours plans example");

            using var schoolAdministrationClient = new KMDStudicaReviewSchoolAdministration(new TokenCredentials(tokenProvider));

            var result = await schoolAdministrationClient.SchoolHoursPlansExternal.GetWithHttpMessagesAsync(
                schoolCode: schoolCode,
                pageNumber: 1,
                pageSize: 10,
                inlineCount: true,
                customHeaders: new Dictionary<string, List<string>>
                {
                    { "Logic-Api-Key", new List<string> { apiKey } }
                });

            Console.WriteLine($"Got {result.Body.TotalItems} plans from API");

            ConsoleTable
                .From(result.Body.Items)
                .Write();
        }
    }
}