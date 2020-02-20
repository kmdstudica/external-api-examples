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
        public async Task Execute(ITokenProvider tokenProvider, string apiKey, string schoolCode)
        {
            Console.WriteLine("Executing student example");

            using var studentsClient = new KMDStudicaDemoStudents(new TokenCredentials(tokenProvider));
            var result = await studentsClient.StudentsExternal.GetWithHttpMessagesAsync(
                studyStartDateFrom: DateTime.Now.AddMonths(-12),
                studyStartDateTo: DateTime.Now.AddMonths(6),
                schoolCode: schoolCode,
                pageNumber: 1,
                pageSize: 10,
                inlineCount: true,
                customHeaders: new Dictionary<string, List<string>>
                {
                    { "Logic-Api-Key", new List<string> { apiKey } }
                });

            Console.WriteLine($"Got {result.Body.TotalItems} students from API");

            ConsoleTable
                .From(result.Body.Items)
                .Write();
        }
    }
}