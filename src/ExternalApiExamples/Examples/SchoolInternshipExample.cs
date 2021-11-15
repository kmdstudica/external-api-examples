using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleTables;
using Kmd.Studica.Programmes.Client;
using Kmd.Studica.SchoolInternships.Client;
using Microsoft.Rest;

namespace ExternalApiExamples
{
    public class SchoolInternshipExample
    {
        private readonly ITokenProvider tokenProvider;
        private readonly AppConfiguration configuration;

        public SchoolInternshipExample(ITokenProvider tokenProvider, AppConfiguration configuration)
        {
            this.tokenProvider = tokenProvider;
            this.configuration = configuration;
        }

        public async Task ExecuteSchoolInternship()
        {
            using var internshipsClient = new KMDStudicaSchoolInternships(new TokenCredentials(tokenProvider));
            internshipsClient.BaseUri = string.IsNullOrEmpty(configuration.SchoolInternshipsBaseUri)
                ? new Uri("https://gateway.kmdlogic.io/studica/school-internships/v1")
                : new Uri(configuration.SchoolInternshipsBaseUri);

            var result = await internshipsClient.StudentInternshipsExternal.GetWithHttpMessagesAsync(
                periodFrom: DateTime.Now.AddMonths(-2),
                periodTo: DateTime.Now.AddMonths(2),
                schoolCode: configuration.SchoolCode,
                customHeaders: new Dictionary<string, List<string>>
                {
                        { "Logic-Api-Key", new List<string> { configuration.StudicaExternalApiKey } }
                });

            Console.WriteLine($"Got {result.Body.Count()} student internships from API");

            ConsoleTable
                .From(result.Body)
                .Write();
        }

        public async Task ExecuteSchoolInternshipAbsence()
        {
            using var internshipsClient = new KMDStudicaSchoolInternships(new TokenCredentials(tokenProvider));
            internshipsClient.BaseUri = string.IsNullOrEmpty(configuration.SchoolInternshipsBaseUri)
                ? new Uri("https://gateway.kmdlogic.io/studica/school-internships/v1")
                : new Uri(configuration.SchoolInternshipsBaseUri);

            var result = await internshipsClient.StudentsInternshipAbsenceExternal.GetWithHttpMessagesAsync(
                periodFrom: DateTime.Now.AddMonths(-2),
                periodTo: DateTime.Now.AddMonths(2),
                schoolCode: configuration.SchoolCode,
                customHeaders: new Dictionary<string, List<string>>
                {
                        { "Logic-Api-Key", new List<string> { configuration.StudicaExternalApiKey } }
                });


            Console.WriteLine($"Got {result.Body.Count()} student internships absence elements from API");

            ConsoleTable
                .From(result.Body)
                .Write();
        }

        public async Task ExecuteStudentInternsipLegacyApi()
        {
            Console.WriteLine("Executing student internhip legacy courses example");

            using var programmesClient = new KMDStudicaProgrammes(new TokenCredentials(tokenProvider));
            programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
                ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
                : new Uri(configuration.ProgrammesBaseUri);

            var result = await programmesClient.StudentInternshipExternal.GetWithHttpMessagesAsync(
                periodFrom: DateTime.Now.AddMonths(-2),
                periodTo: DateTime.Now.AddMonths(2),
                schoolCode: configuration.SchoolCode,
                customHeaders: new Dictionary<string, List<string>>
                {
                        { "Logic-Api-Key", new List<string> { configuration.StudicaExternalApiKey } }
                });

            Console.WriteLine($"Got {result.Body.Count()} student internships from API");

            ConsoleTable
                .From(result.Body)
                .Write();
        }
    }
}