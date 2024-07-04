using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Kmd.Studica.Statistics.Client;
using Kmd.Studica.Statistics.Client.Models;
using Microsoft.Rest;

namespace ExternalApiExamples;

public class StatisticsExample
{
    private readonly ITokenProvider tokenProvider;
    private readonly AppConfiguration configuration;

    public StatisticsExample(ITokenProvider tokenProvider, AppConfiguration configuration)
    {
        this.tokenProvider = tokenProvider;
        this.configuration = configuration;
    }

    public async Task ExecuteSubmitHandinStatistics()
    {
        Console.WriteLine("Executing handin statistics example");

        using var statisticsClient = new StudicaDemoStatistics(new TokenCredentials(tokenProvider));
        statisticsClient.BaseUri = string.IsNullOrEmpty(configuration.StatisticsBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/statistics/v1")
            : new Uri(configuration.StatisticsBaseUri);

        var result = await statisticsClient.SubmitHandinsExternal.PostWithHttpMessagesAsync(
            handins: new[]
            {
                new ExternalHandinDto()
                {
                    HandinId = Guid.NewGuid(),
                    Deadline = DateTime.Now,
                    AssignmentId = Guid.NewGuid(),
                    AssignmentTitle = "Assignment Title",
                    AssignmentType = AssignmentType.TeacherCreatedGroup,
                    AssignmentUrl = "https://assignment.url",
                    ConnectedTopicTitle = "Connected Topic Title",
                    DeliveryTime = DateTime.Now,
                    Feedback = "Great job!",
                    FeedbackTime = DateTime.Now,
                    Status = HandinStatus.Submitted,
                    MarkScale = MarkScale.SevenPointScale,
                    MarkValue = "7",
                    PlagiarismScore = 100,
                    RejectedReason = null,
                    StudentIds = new[] { Guid.NewGuid() },
                    ImmersionTimeInMinutes = 120
                }
            },
            schoolCode: configuration.SchoolCode,
            customHeaders: new Dictionary<string, List<string>>
            {
                { configuration.ApiKeyName, new List<string> { configuration.StudicaExternalApiKey } }
            });

        if (result.Response.IsSuccessStatusCode)
            Console.WriteLine("Handin statistics added");
        else
            Console.WriteLine("Could not add handin statistics");
    }

    public async Task ExecuteDeleteHandinsStatistics()
    {
        Console.WriteLine("Executing delete handin statistics example");

        using var statisticsClient = new StudicaDemoStatistics(new TokenCredentials(tokenProvider));
        statisticsClient.BaseUri = string.IsNullOrEmpty(configuration.StatisticsBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/statistics/v1")
            : new Uri(configuration.StatisticsBaseUri);

        var result = await statisticsClient.DeleteHandinsExternal.PostWithHttpMessagesAsync(
            handinIds: new[] { Guid.NewGuid() },
            schoolCode: configuration.SchoolCode,
            customHeaders: new Dictionary<string, List<string>>
            {
                { configuration.ApiKeyName, new List<string> { configuration.StudicaExternalApiKey } }
            });
    }

    private static class AssignmentType
    {
        public const string Individual = "Individual";
        public const string TeacherCreatedGroup = "TeacherCreatedGroup";
        public const string StudentCreatedGroup  = "StudentCreatedGroup";
        public const string DifferentTasksIndividual = "DifferentTasksIndividual";
    }

    private static class MarkScale
    {
        public const string PassedNotPassed = "PassedNotPassed";
        public const string SevenPointScale = "SevenPointScale";
        public const string PercentScale = "PercentScale";
        public const string NoMarks = "NoMarks";
    }

    private static class HandinStatus
    {
        public const string NotSubmitted = "NotSubmitted";
        public const string Submitted = "Submitted";
        public const string Rejected = "Rejected";
    }
}
