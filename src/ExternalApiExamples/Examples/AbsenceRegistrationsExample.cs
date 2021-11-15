using ConsoleTables;
using Kmd.Studica.Programmes.Client;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Kmd.Studica.Programmes.Client.Models;

namespace ExternalApiExamples
{
    public class AbsenceRegistrationsExample
    {
        enum AbsenceRegistrationStatus
        {
            Present = 0,
            Absent = 1,
            PartialAbsence = 2
        }

        private readonly ITokenProvider tokenProvider;
        private readonly AppConfiguration configuration;

        public AbsenceRegistrationsExample(ITokenProvider tokenProvider, AppConfiguration configuration)
        {
            this.tokenProvider = tokenProvider;
            this.configuration = configuration;
        }

        public async Task Execute()
        {
            Console.WriteLine("Executing get absence registrations example");

            using var programmesClient = new KMDStudicaProgrammes(new TokenCredentials(tokenProvider));
            programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
                ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
                : new Uri(configuration.ProgrammesBaseUri);

            var doContinue = true;
            var pageNum = 0;
            var pageSize = 100;
            var absence = new List<AbsenceRegistrationExternalResponse>();
            do
            {
                var result = await programmesClient.AbsenceRegistrationsExternal.GetWithHttpMessagesAsync(
                    dateFrom: new DateTime(2021, 08, 01),
                    dateTo: new DateTime(2022, 07, 01),
                    onlyAbsenceReports: true,
                    schoolCode: configuration.SchoolCode,
                    pageNumber: ++pageNum,
                    pageSize: pageSize,
                    inlineCount: true,
                    customHeaders: new Dictionary<string, List<string>>
                    {
                        {"Logic-Api-Key", new List<string> {configuration.StudicaExternalApiKey}}
                    });

                if (pageNum == 1)
                {
                    Console.WriteLine($"Reading {result.Body.TotalItems} absence elements");
                }

                absence.AddRange(result.Body.Items);

                Console.Write(".");

                doContinue = pageNum * pageSize < result.Body.TotalItems;
            } while (doContinue);

            Console.WriteLine($"Got {absence.Count} absence registrations from API");

            ConsoleTable
                .From(absence)
                .Write();

        }

        public async Task ExecuteRegisterAbsence()
        {
            Console.WriteLine("Executing add absence registrations example");

            using var programmesClient = new KMDStudicaProgrammes(new TokenCredentials(tokenProvider));
            programmesClient.BaseUri = string.IsNullOrEmpty(configuration.ProgrammesBaseUri)
                ? new Uri("https://gateway.kmdlogic.io/studica/programmes/v1")
                : new Uri(configuration.ProgrammesBaseUri);

            var result = await programmesClient.RegisterAbsenceExternal.PostWithHttpMessagesAsync(
                body: new RegisterAbsenceExternalCommand
                {
                    AbsenceRegistered = true,
                    LessonId = new Guid(),
                    SubjectCourseId = new Guid(),
                    AbsenceRegistrations = new List<RegisterAbsenceRegistrationDto>
                    {
                         new RegisterAbsenceRegistrationDto
                         {
                             Approved = true,
                             Comment = "Student had dentist appointment",
                             Minutes = 10,
                             Status = AbsenceRegistrationStatus.PartialAbsence.ToString("D"),
                             StudentId = new Guid()
                         },
                         new RegisterAbsenceRegistrationDto
                         {
                             Approved = false,
                             Comment = "Student didn't show up",
                             Minutes = 0,
                             Status = AbsenceRegistrationStatus.Absent.ToString("D"),
                             StudentId = new Guid()
                         }
                    },
                    SchoolCode = configuration.SchoolCode,
                },
                customHeaders: new Dictionary<string, List<string>>
                {
                     {"Logic-Api-Key", new List<string> {configuration.StudicaExternalApiKey}}
                });
        }
    }
}