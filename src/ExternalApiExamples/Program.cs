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

            using var externalApiHttpClient = new HttpClient();
            externalApiHttpClient.BaseAddress = configuration.StudicaExternalApiBaseAddress;
            externalApiHttpClient.DefaultRequestHeaders.Add("Logic-Api-Key", configuration.StudicaExternalApiKey);

            await new StudentsExample().Execute(tokenProvider, externalApiHttpClient);
            await new EmployeeExample().Execute(tokenProvider, externalApiHttpClient);
            await new RoomsExample().Execute(tokenProvider, externalApiHttpClient);
            await new SchoolHoursPlansExample().Execute(tokenProvider, externalApiHttpClient);
            await new SchoolHourEntryExample().Execute(tokenProvider, externalApiHttpClient);
            await new EducationalProgrammesExample().Execute(tokenProvider, externalApiHttpClient);
            await new SubjectCoursesExample().Execute(tokenProvider, externalApiHttpClient);
        }
    }
}