using ExternalApiExamples.Clients;
using Kmd.Logic.Identity.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Rest;
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
            using var httpClient = new HttpClient
            {
                BaseAddress = configuration.StudicaExternalApiBaseAddress
            };
            var tokenProvider = CreateLogicTokenProvider(configuration.TokenProviderOptions, httpClient);
            await new StudentsExample().Execute(tokenProvider);
            await new EmployeeExample().Execute(tokenProvider);
            await new RoomsExample().Execute(tokenProvider);
            await new SchoolHoursPlansExample().Execute(tokenProvider);
            await new SchoolHourEntryExample().Execute(tokenProvider);
            await new StudentsExample().Execute(tokenProvider);
            await new EducationalProgrammesExample().Execute(tokenProvider);
            await new SubjectCoursesExample().Execute(tokenProvider);
        }

        private static ITokenProvider CreateLogicTokenProvider(TokenProviderOptions tokenProviderOptions, HttpClient httpClient) =>
            new LogicTokenProviderFactory(
                new LogicTokenProviderOptions
                {
                    AuthorizationScope = tokenProviderOptions.AuthorizationScope,
                    AuthorizationTokenIssuer = tokenProviderOptions.AuthorizationTokenIssuer,
                    ClientId = tokenProviderOptions.ClientId,
                    ClientSecret = tokenProviderOptions.ClientSecret
                })
            .GetProvider(httpClient);
    }
}