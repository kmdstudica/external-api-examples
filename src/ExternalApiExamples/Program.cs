using Kmd.Logic.Identity.Authorization;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ExternalApiExamples
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            try
            {
                var config = new ConfigurationBuilder()
                    .SetBasePath(AppContext.BaseDirectory)
                    .AddJsonFile("appsettings.json", optional: false)
                    .AddEnvironmentVariables()
                    .Build()
                    .Get<AppConfiguration>();

                await Run(config).ConfigureAwait(false);
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
#pragma warning restore CA1031 // Do not catch general exception types
        }

        private static async Task Run(AppConfiguration configuration)
        {
            Console.WriteLine("KMD Studica Examples");

            using var httpClient = new HttpClient();
            var tokenProvider = new LogicTokenProviderFactory(configuration.TokenProvider).GetProvider(httpClient);

            await new StudentsExample().Execute(tokenProvider, configuration.StudicaExternalApiKey);
            await new EmployeeExample().Execute(tokenProvider, configuration.StudicaExternalApiKey);
            await new RoomsExample().Execute(tokenProvider, configuration.StudicaExternalApiKey);
            await new SchoolHoursPlansExample().Execute(tokenProvider, configuration.StudicaExternalApiKey);
            await new SchoolHourEntryExample().Execute(tokenProvider, configuration.StudicaExternalApiKey);
            await new EducationalProgrammesExample().Execute(tokenProvider, configuration.StudicaExternalApiKey);
            await new SubjectCoursesExample().Execute(tokenProvider, configuration.StudicaExternalApiKey);
        }
    }
}