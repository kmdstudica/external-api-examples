using ConsoleTables;
using Kmd.Studica.Students.Client;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Kmd.Studica.Students.Client.Models;

namespace ExternalApiExamples
{
    public class StudentsExample
    {
        private readonly ITokenProvider tokenProvider;
        private readonly AppConfiguration configuration;

        public StudentsExample(ITokenProvider tokenProvider, AppConfiguration configuration)
        {
            this.tokenProvider = tokenProvider;
            this.configuration = configuration;
        }

        public async Task Execute()
        {
            Console.Write("Executing student example");

            using var studentsClient = new KMDStudicaStudents(new TokenCredentials(tokenProvider));
            studentsClient.BaseUri = string.IsNullOrEmpty(configuration.StudentsBaseUri)
                ? new Uri("https://gateway.kmdlogic.io/studica/students/v1")
                : new Uri(configuration.StudentsBaseUri);

            var students = new List<StudentExternalResponse>();

            bool hasMorePages;
            int pageNumber = 0;
            int pageSize = 1000;
            do
            {
                var result = await studentsClient.ActiveStudentsExternal.GetWithHttpMessagesAsync(
                    studentActiveOnOrAfterDate: new DateTime(DateTime.Today.Year, 01, 01),
                    schoolCode: configuration.SchoolCode,
                    pageNumber: ++pageNumber,
                    pageSize: pageSize,
                    inlineCount: true,
                    customHeaders: new Dictionary<string, List<string>>
                    {
                        {"Logic-Api-Key", new List<string> {configuration.StudicaExternalApiKey}}
                    });

                hasMorePages = pageNumber * pageSize < result.Body.TotalItems;
                students.AddRange(result.Body.Items);
                Console.Write(".");
            } while (hasMorePages);

            Console.WriteLine();
            Console.WriteLine($"Got {students.Count} students from API");
            ConsoleTable
                .From(students)
                .Write();
        }

        public async Task ExecuteBulk()
        {
            Console.WriteLine("Executing bulk student example");

            using var studentsClient = new KMDStudicaStudents(new TokenCredentials(tokenProvider));
            studentsClient.BaseUri = string.IsNullOrEmpty(configuration.StudentsBaseUri)
                ? new Uri("https://gateway.kmdlogic.io/studica/students/v1")
                : new Uri(configuration.StudentsBaseUri);

            var result = await studentsClient.BulkStudentsExternal.PostWithHttpMessagesAsync(
                studentIds: new[] {Guid.NewGuid()},
                schoolCode: configuration.SchoolCode,
                customHeaders: new Dictionary<string, List<string>>
                {
                    {"Logic-Api-Key", new List<string> {configuration.StudicaExternalApiKey}}
                });

            Console.WriteLine($"Got {result.Body} students from API");

            ConsoleTable
                .From(result.Body)
                .Write();
        }
    }
}