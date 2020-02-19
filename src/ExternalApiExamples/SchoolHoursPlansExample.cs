using ConsoleTables;
using Kmd.Studica.SchoolAdministration.Client;
using Microsoft.Rest;
using System;
using System.Threading.Tasks;

namespace ExternalApiExamples
{
    public class SchoolHoursPlansExample
    {
        public async Task Execute(ITokenProvider tokenProvider)
        {
            Console.WriteLine("Executing school hours plans example");

            using var schoolAdministrationClient = new SchoolAdministrationHost(new TokenCredentials(tokenProvider));

            var result = await schoolAdministrationClient.SchoolHoursPlansExternal.GetWithHttpMessagesAsync(
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