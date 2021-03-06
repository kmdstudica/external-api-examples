﻿using Kmd.Logic.Identity.Authorization;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ExternalApiExamples
{
    public static class Program
    {
        private static async Task Main(string[] args)
        {
            try
            {
                var config = new ConfigurationBuilder()
                    .SetBasePath(AppContext.BaseDirectory)
                    .AddJsonFile("appsettings.json", optional: false)
                    .AddUserSecrets(typeof(Program).Assembly)
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
            var tokenProvider = string.IsNullOrEmpty(configuration.LocalTestJwtToken)
                ? new LogicTokenProviderFactory(configuration.TokenProvider).GetProvider(httpClient)
                : new LocalTestTokenProvider(configuration.LocalTestJwtToken);

            // NOTE: Samples that post data to STUDICA are disabled pr. default

            // Students API examples
            await new StudentsExample(tokenProvider, configuration).Execute();
            await new StudentsExample(tokenProvider, configuration).ExecuteBulk();
            await new StudentMarksExample(tokenProvider, configuration).Execute();

            // School administration API examples
            await new AreaOfResponsibilityExample(tokenProvider, configuration).Execute();
            await new AreaOfResponsibilityExample(tokenProvider, configuration).ExecuteBulk();
            await new DayCalendarsExample(tokenProvider, configuration).Execute();
            await new DepartmentsExample(tokenProvider, configuration).Execute();
            await new DepartmentsExample(tokenProvider, configuration).ExecuteBulk();
            await new EmployeeExample(tokenProvider, configuration).Execute();
            await new EmployeeExample(tokenProvider, configuration).ExecuteBulk();
            await new EmployeeExample(tokenProvider, configuration).ExecuteActiveEmployees();
            await new SchoolHourEntryExample(tokenProvider, configuration).Execute();
            await new SchoolHoursPlansExample(tokenProvider, configuration).Execute();
            await new SchoolHoursPlansExample(tokenProvider, configuration).ExecuteDetailed();
            await new RoomsExample(tokenProvider, configuration).Execute();
            await new RoomsExample(tokenProvider, configuration).ExecuteBulk();

            // Programmes API examples
            await new EducationalProgrammesExample(tokenProvider, configuration).Execute();
            await new EducationalProgrammesExample(tokenProvider, configuration).ExecuteBulk();
            await new SubjectCoursesExample(tokenProvider, configuration).Execute();
            await new SubjectCoursesExample(tokenProvider, configuration).ExecuteBulk();
            await new SubjectCoursesExample(tokenProvider, configuration).ExecuteStudentSubjectCourses();
            await new SubjectCoursesExample(tokenProvider, configuration).ExecuteActiveSubjectCourses();
            await new LessonsExample(tokenProvider, configuration).ExecuteGet();
            await new LessonsExample(tokenProvider, configuration).ExecuteGetBulk();
            await new LessonsExample(tokenProvider, configuration).ExecuteGetUnscheduled();
            //await new LessonsExample(tokenProvider, configuration).ExecuteAddLessons();
            //await new LessonsExample(tokenProvider, configuration).ExecuteEditLesson();
            //await new LessonsExample(tokenProvider, configuration).ExecuteDeleteLesson();
            //await new LessonsExample(tokenProvider, configuration).ExecuteDeleteLessons();
            await new AbsenceRegistrationsExample(tokenProvider, configuration).Execute();
            //await new AbsenceRegistrationsExample(tokenProvider, configuration).ExecuteRegisterAbsence();
            await new SchoolCoursesExample(tokenProvider, configuration).Execute();
            await new SchoolCoursesExample(tokenProvider, configuration).ExecuteStudentSchoolCourses();
            await new StudentInternshipExample(tokenProvider, configuration).Execute();
            await new ActivityReportsExample(tokenProvider, configuration).Execute();
            await new BridgingCoursesExample(tokenProvider, configuration).Execute();
        }
    }
}