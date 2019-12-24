using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ConsoleTables;
using Kmd.Studica.SchoolAdministration.Client;
using Microsoft.Rest;

namespace ExternalApiExamples
{
    public class RoomsExample
    {
        public async Task Execute(ITokenProvider tokenProvider)
        {
            Console.WriteLine("Executing rooms example");

            using var schoolAdministrationClient = new SchoolAdministrationHost(new TokenCredentials(tokenProvider));

            var result = await schoolAdministrationClient.Rooms.GetWithHttpMessagesAsync(
                pageNumber: 1,
                pageSize: 10,
                inlineCount: true,
                institutionNumber: "",
                customHeaders: new Dictionary<string, List<string>>
                {
                    { "X-Host-To-Host", new List<string>{"true"} }
                });

            Console.WriteLine($"Got {result.Body.TotalItems} rooms from API");

            ConsoleTable
                .From(result.Body.Items)
                .Write();
        }
    }
}