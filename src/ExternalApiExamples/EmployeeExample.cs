using ConsoleTables;
using Kmd.Studica.SchoolAdministration.Client;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExternalApiExamples
{
    public class EmployeeExample
    {
        public async Task Execute(ITokenProvider tokenProvider)
        {
            Console.WriteLine("Executing employee example");

            using var schoolAdministrationClient = new SchoolAdministrationHost(new TokenCredentials(tokenProvider));

            var result = await schoolAdministrationClient.EmployeesExternal.GetWithHttpMessagesAsync(
                employmentStartDateFrom: DateTime.Now.AddYears(-1),
                employmentStartDateTo: DateTime.Now,
                schoolCode: Configuration.TestSchoolCode,
                pageNumber: 1,
                pageSize: 10,
                inlineCount: true);

            Console.WriteLine($"Got {result.Body.TotalItems} employees from API");

            ConsoleTable
                .From(result.Body.Items)
                .Write();
        }
    }
}