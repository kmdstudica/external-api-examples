using Kmd.Logic.Identity.Authorization;

namespace ExternalApiExamples
{
    public class AppConfiguration
    {
        public LogicTokenProviderOptions TokenProvider { get; set; }

        public string StudicaExternalApiKey { get; set; }

        public string SchoolCode { get; set; }

        public string SchoolAdministrationBaseUri { get; set; }

        public string ProgrammesBaseUri { get; set; }

        public string StudentsBaseUri { get; set; }

        public string LocalTestJwtToken { get; set; }
    }
}