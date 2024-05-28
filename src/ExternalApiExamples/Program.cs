using Kmd.Logic.Identity.Authorization;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Threading.Tasks;

#pragma warning disable CS1998

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

                if (string.IsNullOrEmpty(config.ApiKeyName))
                {
                    config.ApiKeyName = "Logic-Api-Key";
                }

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

            /*
             * Students API examples
             */
            // await new StudentsExample(tokenProvider, configuration).Execute();
            // await new StudentsExample(tokenProvider, configuration).ExecuteBulk();
            // await new StudentMarksExample(tokenProvider, configuration).Execute();
            // await new StudentsExample(tokenProvider, configuration).ExecuteUpdateContactInformation();

            /*
             * School administration API examples
             */
            // await new AreaOfResponsibilityExample(tokenProvider, configuration).Execute();
            // await new AreaOfResponsibilityExample(tokenProvider, configuration).ExecuteBulk();
            // await new AreaOfEducationExample(tokenProvider, configuration).Execute();
            // await new DayCalendarsExample(tokenProvider, configuration).Execute();
            // await new DepartmentsExample(tokenProvider, configuration).Execute();
            // await new DepartmentsExample(tokenProvider, configuration).ExecuteBulk();
            // await new EmployeeExample(tokenProvider, configuration).Execute();
            // await new EmployeeExample(tokenProvider, configuration).ExecuteBulk();
            // await new EmployeeExample(tokenProvider, configuration).ExecuteActiveEmployees();
            // await new EmployeeExample(tokenProvider, configuration).ExecuteUpdateContactInformation();
            // await new SchoolHourEntryExample(tokenProvider, configuration).Execute();
            // await new SchoolHoursPlansExample(tokenProvider, configuration).Execute();
            // await new SchoolHoursPlansExample(tokenProvider, configuration).ExecuteDetailed();
            // await new RoomsExample(tokenProvider, configuration).Execute();
            // await new RoomsExample(tokenProvider, configuration).ExecuteBulk();

            /*
             * Programmes API examples
             */
            // await new EducationalProgrammesExample(tokenProvider, configuration).Execute();
            // await new EducationalProgrammesExample(tokenProvider, configuration).ExecuteBulk();
            // await new SubjectCoursesExample(tokenProvider, configuration).Execute();
            // await new SubjectCoursesExample(tokenProvider, configuration).ExecuteBulk();
            // await new SubjectCoursesExample(tokenProvider, configuration).ExecuteStudentSubjectCourses();
            // await new SubjectCoursesExample(tokenProvider, configuration).ExecuteActiveSubjectCourses();
            // await new GroupsExample(tokenProvider, configuration).ExecuteGroups();
            // await new SessionsExample(tokenProvider, configuration).ExecuteSessions();
            // await new SessionsExample(tokenProvider, configuration).ExecuteSessionsById();
            // await new SessionsExample(tokenProvider, configuration).ExecuteAddSessionsToSubjectCourses();
            // await new SessionsExample(tokenProvider, configuration).ExecuteEditSubjectCourseSession();
            // await new SessionsExample(tokenProvider, configuration).ExecuteDeleteSessions();
            // await new AbsenceRegistrationsExample(tokenProvider, configuration).Execute();
            // await new AbsenceRegistrationsExample(tokenProvider, configuration).ExecuteRegisterAbsence();
            // await new SchoolCoursesExample(tokenProvider, configuration).Execute();
            // await new SchoolCoursesExample(tokenProvider, configuration).ExecuteStudentSchoolCourses();
            // await new ActivityReportsExample(tokenProvider, configuration).ExecuteStudentActivityReports();
            // await new ActivityReportsExample(tokenProvider, configuration).ExecuteActivitiesReport();
            // await new BridgingCoursesExample(tokenProvider, configuration).ExecuteActiveBridgingCourses();
            // await new BridgingCoursesExample(tokenProvider, configuration).ExecuteBridgingCourseStudents();

            /*
             * School Internships API examples
             */
            // await new SchoolInternshipExample(tokenProvider, configuration).ExecuteSchoolInternshipV2();
            // await new SchoolInternshipExample(tokenProvider, configuration).ExecuteSchoolInternshipAbsence();
            // await new SchoolInternshipExample(tokenProvider, configuration).ExecuteActiveInternshipDepartments();
            // await new SchoolInternshipExample(tokenProvider, configuration).ExecuteBulkInternshipDepartments();
            
            /*
             * InternshipDK API examples
             */
            // await new InternshipDkExample(tokenProvider, configuration).Execute();
            
            /*
             * Statistics API examples
             */
            // await new StatisticsExample(tokenProvider, configuration).ExecuteSubmitHandinStatistics();
            // await new StatisticsExample(tokenProvider, configuration).ExecuteDeleteHandinsStatistics();
        }
    }
}
