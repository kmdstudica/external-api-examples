using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ConsoleTables;
using Kmd.Studica.SchoolAdministration.Client;
using Kmd.Studica.SchoolAdministration.Client.Models;
using Microsoft.Rest;

namespace ExternalApiExamples;

public class EmployeeExample
{
    private readonly ITokenProvider tokenProvider;
    private readonly AppConfiguration configuration;

    public EmployeeExample(ITokenProvider tokenProvider, AppConfiguration configuration)
    {
        this.tokenProvider = tokenProvider;
        this.configuration = configuration;
    }

    public async Task Execute()
    {
        Console.WriteLine("Executing employees example");

        using var schoolAdministrationClient = new KMDStudicaSchoolAdministration(new TokenCredentials(tokenProvider));
        schoolAdministrationClient.BaseUri = string.IsNullOrEmpty(configuration.SchoolAdministrationBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/school-administration/v1")
            : new Uri(configuration.SchoolAdministrationBaseUri);

        var result = await schoolAdministrationClient.EmployeesExternal.GetWithHttpMessagesAsync(
            employmentStartDateFrom: DateTime.Now.AddYears(-1),
            employmentStartDateTo: DateTime.Now,
            schoolCode: configuration.SchoolCode,
            pageNumber: 1,
            pageSize: 10,
            inlineCount: true,
            customHeaders: new Dictionary<string, List<string>>
            {
                { configuration.ApiKeyName, new List<string> { configuration.StudicaExternalApiKey } }
            });

        Console.WriteLine($"Got {result.Body.TotalItems} employees from API");

        ConsoleTable
            .From(result.Body.Items)
            .Write();
    }

    public async Task ExecuteBulk()
    {
        Console.WriteLine("Executing bulk employees example");

        using var schoolAdministrationClient = new KMDStudicaSchoolAdministration(new TokenCredentials(tokenProvider));
        schoolAdministrationClient.BaseUri = string.IsNullOrEmpty(configuration.SchoolAdministrationBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/school-administration/v1")
            : new Uri(configuration.SchoolAdministrationBaseUri);

        var result = await schoolAdministrationClient.BulkEmployeesExternal.PostWithHttpMessagesAsync(
            employeeIds: new[] { Guid.NewGuid() },
            schoolCode: configuration.SchoolCode,
            customHeaders: new Dictionary<string, List<string>>
            {
                { configuration.ApiKeyName, new List<string> { configuration.StudicaExternalApiKey } }
            });

        Console.WriteLine($"Got {result.Body.Count} employees from API");

        ConsoleTable
            .From(result.Body)
            .Write();
    }

    public async Task ExecuteActiveEmployees()
    {
        Console.WriteLine("Executing active employees example");
        using var schoolAdministrationClient = new KMDStudicaSchoolAdministration(new TokenCredentials(tokenProvider));
        schoolAdministrationClient.BaseUri = string.IsNullOrEmpty(configuration.SchoolAdministrationBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/school-administration/v1")
            : new Uri(configuration.SchoolAdministrationBaseUri);

        bool hasMorePages;
        var pageNumber = 0;
        var pageSize = 100;
        var employees = new List<EmployeeExternalResponse>();
        do
        {
            var result = await schoolAdministrationClient.ActiveEmployeesExternal.GetWithHttpMessagesAsync(
                employeesActiveOnOrAfterDate: DateTime.Today,
                schoolCode: configuration.SchoolCode,
                pageNumber: ++pageNumber,
                pageSize: pageSize,
                inlineCount: true,
                customHeaders: new Dictionary<string, List<string>>
                {
                    { "Logic-Api-Key", new List<string> { configuration.StudicaExternalApiKey } }
                });

            hasMorePages = pageNumber * pageSize < result.Body.TotalItems;
            employees.AddRange(result.Body.Items);
        } while (hasMorePages);

        Console.WriteLine($"Got {employees.Count} employees from API");
        ConsoleTable
            .From(employees)
            .Write();
    }

    public async Task ExecuteUpdateContactInformation()
    {
        Console.WriteLine("Executing update student contact information example");

        using var schoolAdministrationClient = new KMDStudicaSchoolAdministration(new TokenCredentials(tokenProvider));
        schoolAdministrationClient.BaseUri = string.IsNullOrEmpty(configuration.SchoolAdministrationBaseUri)
            ? new Uri("https://gateway.kmdlogic.io/studica/school-administration/v1")
            : new Uri(configuration.SchoolAdministrationBaseUri);

        try
        {
            var result = await schoolAdministrationClient.UpdateContactAndAccountInfoExternal.PostWithHttpMessagesAsync(
                body: new UpdateContactAndAccountInfoExternalCommand
                {
                    EmployeeId = Guid.Empty,
                    SchoolCode = configuration.SchoolCode,
                    GivenName = null,
                    Surname = null,
                    Initials = null,
                    AddressLine = null,
                    AddressLineClear = false,
                    CareOfAddress = null,
                    CareOfAddressClear = false,
                    Place = null,
                    PlaceClear = false,
                    City = null,
                    CityClear = false,
                    PostalCode = null,
                    PostalCodeClear = false,
                    Country = null,
                    CountryClear = false,
                    Email = null,
                    EmailClear = false,
                    PrivateEmail = null,
                    PrivateEmailClear = false,
                    PhoneNumber = null,
                    PhoneNumberClear = false,
                    MobileNumber = null,
                    MobileNumberClear = false,
                    PrivatePhoneNumber = null,
                    PrivatePhoneNumberClear = false,
                    AdUsername = null
                },
                customHeaders: new Dictionary<string, List<string>>
                {
                    { configuration.ApiKeyName, new List<string> { configuration.StudicaExternalApiKey } }
                });

            if (result.Response.IsSuccessStatusCode)
                Console.WriteLine("Contact information updated");
            else
                Console.WriteLine("Could not update contact information");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
