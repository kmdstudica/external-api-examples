using Kmd.Logic.Identity.Authorization;

namespace ExternalApiExamples
{
    public class AppConfiguration
    {
        public LogicTokenProviderOptions TokenProvider { get; set; }
        
        public string ApiKeyName { get; set; }

        public string StudicaExternalApiKey { get; set; }

        public string SchoolCode { get; set; }

        public string InternshipDkBaseUri { get; set; }
        
        public string SchoolAdministrationBaseUri { get; set; }

        public string SchoolInternshipsBaseUri { get; set; }

        public string ProgrammesBaseUri { get; set; }

        public string StatisticsBaseUri { get; set; }
        
        public string StudentsBaseUri { get; set; }

        public string LocalTestJwtToken { get; set; }
    }
}
