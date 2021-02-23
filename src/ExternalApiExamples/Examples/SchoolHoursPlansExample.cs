using ConsoleTables;
using Kmd.Studica.SchoolAdministration.Client;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExternalApiExamples
{
    public class SchoolHoursPlansExample
    {
        private readonly ITokenProvider tokenProvider;
        private readonly AppConfiguration configuration;

        public SchoolHoursPlansExample(ITokenProvider tokenProvider, AppConfiguration configuration)
        {
            this.tokenProvider = tokenProvider;
            this.configuration = configuration;
        }

        public async Task Execute()
        {
            Console.WriteLine("Executing school hours plans example");

            using var schoolAdministrationClient =
                new KMDStudicaSchoolAdministration(new TokenCredentials(tokenProvider));
            schoolAdministrationClient.BaseUri = string.IsNullOrEmpty(configuration.SchoolAdministrationBaseUri)
                ? new Uri("https://gateway.kmdlogic.io/studica/school-administration/v1")
                : new Uri(configuration.SchoolAdministrationBaseUri);

            var result = await schoolAdministrationClient.SchoolHoursPlansExternal.GetWithHttpMessagesAsync(
                schoolCode: configuration.SchoolCode,
                pageNumber: 1,
                pageSize: 10,
                inlineCount: true,
                customHeaders: new Dictionary<string, List<string>>
                {
                    {"Logic-Api-Key", new List<string> {configuration.StudicaExternalApiKey}}
                });

            Console.WriteLine($"Got {result.Body.TotalItems} plans from API");

            ConsoleTable
                .From(result.Body.Items)
                .Write();
        }

        public async Task ExecuteDetailed()
        {
            Console.WriteLine("Executing detailed school hours plans example");

            using var schoolAdministrationClient =
                new KMDStudicaSchoolAdministration(new TokenCredentials(tokenProvider));
            schoolAdministrationClient.BaseUri = string.IsNullOrEmpty(configuration.SchoolAdministrationBaseUri)
                ? new Uri("https://gateway.kmdlogic.io/studica/school-administration/v1")
                : new Uri(configuration.SchoolAdministrationBaseUri);

            try
            {
                var result = await schoolAdministrationClient.SchoolHoursPlanDetailsExternal.GetWithHttpMessagesAsync(
                    schoolCode: configuration.SchoolCode,
                    id: Guid.NewGuid(),
                    customHeaders: new Dictionary<string, List<string>>
                    {
                        {"Logic-Api-Key", new List<string> {configuration.StudicaExternalApiKey}}
                    });
            
                Console.WriteLine($"Got school hour plan from API: {result.Body?.Name}");
            
                if (result.Body?.SchoolHours.Count() > 0)
                {
                    ConsoleTable.From(result.Body.SchoolHours).Write();
                }
            }
            catch (HttpOperationException e)
            {
                // Sample error handler. If this service is called with a not-existing plan id,
                // the service will return HTTP 404 (NotFound)
                Console.WriteLine(e);
            }
        }
    }
}