using ConsoleTables;
using Kmd.Studica.Programmes.Client;
using Microsoft.Rest;
using System;
using System.Threading.Tasks;

namespace ExternalApiExamples
{
    public class SubjectCoursesExample
    {
        public async Task Execute(ITokenProvider tokenProvider)
        {
            Console.WriteLine("Executing subject courses example");

            using var programmesClient = new ProgrammesHost(new TokenCredentials(tokenProvider));
            var result = await programmesClient.SubjectCoursesExternal.GetWithHttpMessagesAsync(
                startDateFrom: DateTime.Now.AddMonths(-12),
                startDateTo: DateTime.Now.AddMonths(6),
                schoolCode: Configuration.TestSchoolCode,
                pageNumber: 1,
                pageSize: 10,
                inlineCount: true);

            Console.WriteLine($"Got {result.Body.TotalItems} subject courses from API");

            ConsoleTable
                .From(result.Body.Items)
                .Write();
        }
    }
}