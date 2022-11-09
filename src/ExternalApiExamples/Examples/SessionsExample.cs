using ConsoleTables;
using Kmd.Studica.Programmes.Client;
using Kmd.Studica.Programmes.Client.Models;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExternalApiExamples
{
    public class SessionsExample
    {
        private readonly ITokenProvider tokenProvider;
        private readonly AppConfiguration configuration;

        public SessionsExample(ITokenProvider tokenProvider, AppConfiguration configuration)
        {
            this.tokenProvider = tokenProvider;
            this.configuration = configuration;
        }

        public async Task ExecuteSessionsById()
        {
            
        }

        public async Task ExecuteSessions()
        {
            
        }

        public async Task ExecuteAddIndependentSession()
        {
            
        }

        public async Task ExecuteAddSessionsToSubjectCourses()
        {
            
        }

        public async Task ExecuteDeleteSessions()
        {
            
        }

        public async Task ExecuteEditIndependentSession()
        {
            
        }

        public async Task ExecuteEditSubjectCourseSession()
        {
            
        }
    }
}