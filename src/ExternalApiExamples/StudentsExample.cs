using ConsoleTables;
using Kmd.Studica.Students.Client;
using Microsoft.Rest;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ExternalApiExamples
{
    public class StudentsExample
    {
        public async Task Execute(ITokenProvider tokenProvider, Func<HttpClient> getHttpClient)
        {
            Console.WriteLine("Executing student example");

            using var studentsClient = new StudentsHost(new TokenCredentials(tokenProvider), getHttpClient(), true);
            var result = await studentsClient.StudentsExternal.GetWithHttpMessagesAsync(
                studyStartDateFrom: DateTime.Now.AddMonths(-12),
                studyStartDateTo: DateTime.Now.AddMonths(6),
                schoolCode: Configuration.TestSchoolCode,
                pageNumber: 1,
                pageSize: 10,
                inlineCount: true);

            Console.WriteLine($"Got {result.Body.TotalItems} students from API");

            ConsoleTable
                .From(result.Body.Items)
                .Write();
        }
    }
}