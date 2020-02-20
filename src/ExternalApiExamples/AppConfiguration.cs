using Kmd.Logic.Identity.Authorization;

namespace ExternalApiExamples
{
    internal class AppConfiguration
    {
        public LogicTokenProviderOptions TokenProvider { get; set; }

        public string StudicaExternalApiKey { get; set; }

        public string SchoolCode { get; set; }
    }
}