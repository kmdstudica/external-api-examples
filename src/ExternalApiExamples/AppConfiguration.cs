using Kmd.Logic.Identity.Authorization;
using System;

namespace ExternalApiExamples
{
    internal class AppConfiguration
    {
        public LogicTokenProviderOptions TokenProvider { get; set; }

        public Uri StudicaExternalApiBaseAddress { get; set; }

        public string StudicaExternalApiKey { get; set; }
    }
}