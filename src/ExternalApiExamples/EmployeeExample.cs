using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ConsoleTables;
using Kmd.Studica.Employees.Client;
using Microsoft.Rest;

namespace ExternalApiExamples
{
    public class EmployeeExample
    {
        public async Task Execute(ITokenProvider tokenProvider)
        {
            Console.WriteLine("Executing employee example");
            
            using (var employeeClient = new SchoolAdministrationHost(new TokenCredentials(tokenProvider)))
            {
                var result = await employeeClient.Employees.GetWithHttpMessagesAsync(
                    1,
                    10,
                    true,
                    DateTime.Now.AddYears(-1),
                    DateTime.Now,
                    "",
                    new Dictionary<string, List<string>>
                    {
                        { "X-Host-To-Host", new List<string>{"true"} } 
                    });
                
                Console.WriteLine($"Got {result.Body.TotalItems} employees from API");
                
                ConsoleTable
                    .From(result.Body.Items)
                    .Write();
            }
        }
    }
}