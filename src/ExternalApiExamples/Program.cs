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

            await new StudentsExample().Execute(tokenProvider, GetStudicaExternalApiHttpClient(configuration));
            await new EmployeeExample().Execute(tokenProvider, GetStudicaExternalApiHttpClient(configuration));
            await new RoomsExample().Execute(tokenProvider, GetStudicaExternalApiHttpClient(configuration));
            await new SchoolHoursPlansExample().Execute(tokenProvider, GetStudicaExternalApiHttpClient(configuration));
            await new SchoolHourEntryExample().Execute(tokenProvider, GetStudicaExternalApiHttpClient(configuration));
            await new EducationalProgrammesExample().Execute(tokenProvider, GetStudicaExternalApiHttpClient(configuration));
            await new SubjectCoursesExample().Execute(tokenProvider, GetStudicaExternalApiHttpClient(configuration));
        }

        private static Func<HttpClient> GetStudicaExternalApiHttpClient(AppConfiguration appConfiguration)
        {
            return () =>
            {
                var httpClient = new HttpClient();
                httpClient.BaseAddress = appConfiguration.StudicaExternalApiBaseAddress;
                httpClient.DefaultRequestHeaders.Add("logic-api-key", appConfiguration.StudicaExternalApiKey);
                return httpClient;
            };
        }
    }
}