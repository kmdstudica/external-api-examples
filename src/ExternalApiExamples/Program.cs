using System;
using System.Threading.Tasks;
using ExternalApiExamples.Clients;

namespace ExternalApiExamples
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            Console.WriteLine("KMD Studica Examples");
            var tokenProvider = new StudicaHostToHostTokenProvider("-- SECRET --");
            await new StudentsExample().Execute(tokenProvider);
            await new EmployeeExample().Execute(tokenProvider);
            await new RoomsExample().Execute(tokenProvider);
            await new SchoolHoursPlansExample().Execute(tokenProvider);
            await new SchoolHourEntryExample().Execute(tokenProvider);
            await new StudentsExample().Execute(tokenProvider);
            await new EducationalProgrammesExample().Execute(tokenProvider);
            await new SubjectCoursesExample().Execute(tokenProvider);
        }
    }
}