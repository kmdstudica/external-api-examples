using ConsoleTables;
using Kmd.Studica.SchoolAdministration.Client;
using Microsoft.Rest;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ExternalApiExamples
{
    public class SchoolHourEntryExample
    {
        public async Task Execute(ITokenProvider tokenProvider, HttpClient httpClient)
        {
            Console.WriteLine("Executing school hour entry example");

            using var schoolAdministrationClient = new SchoolAdministrationHost(new TokenCredentials(tokenProvider), httpClient, false);

            var result = await schoolAdministrationClient.SchoolHourEntriesExternal.GetWithHttpMessagesAsync(
                schoolCode: Configuration.TestSchoolCode,
                pageNumber: 1,
                pageSize: 10,
                inlineCount: true);

            Console.WriteLine($"Got {result.Body.TotalItems} plans from API");

            ConsoleTable
                .From(result.Body.Items)
                .Write();
        }
    }
}