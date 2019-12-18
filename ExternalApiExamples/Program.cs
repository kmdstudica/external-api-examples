using System;
using System.Threading.Tasks;
using ExternalApiExamples.Clients;

namespace ExternalApiExamples
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("KMD Studica Examples");
            var tokenProvider = new StudicaHostToHostTokenProvider("-- SECRET --");
            await new EmployeeExample().Execute(tokenProvider);
            
            
        }

        
    }
}