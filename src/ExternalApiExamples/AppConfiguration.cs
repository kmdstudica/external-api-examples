using ExternalApiExamples.Clients;
using System;

namespace ExternalApiExamples
{
    internal class AppConfiguration
    {
        public TokenProviderOptions TokenProviderOptions { get; set; }
        public Uri StudicaExternalApiBaseAddress { get; set; }
    }
}