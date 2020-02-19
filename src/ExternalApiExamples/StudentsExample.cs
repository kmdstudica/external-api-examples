using ConsoleTables;
using Kmd.Studica.Students.Client;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExternalApiExamples
{
    public class StudentsExample
    {
        public async Task Execute(ITokenProvider tokenProvider)
        {
            Console.WriteLine("Executing student example");

            using var studentsClient = new StudentsHost(new TokenCredentials(tokenProvider));
            var result = await studentsClient.StudentsExternal.GetWithHttpMessagesAsync(
                studyStartDateFrom: DateTime.Now.AddMonths(-12),
                studyStartDateTo: DateTime.Now.AddMonths(6),
                schoolCode: Configuration.TestSchoolCode,
                pageNumber: 1,
                pageSize: 10,
                inlineCount: true,
                new Dictionary<string, List<string>>
                {
                    { "X-Host-To-Host", new List<string>{"true"} }
                });

            Console.WriteLine($"Got {result.Body.TotalItems} students from API");

            ConsoleTable
                .From(result.Body.Items)
                .Write();
        }
    }
}