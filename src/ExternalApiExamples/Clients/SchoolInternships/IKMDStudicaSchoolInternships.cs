// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.SchoolInternships.Client
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// </summary>
    public partial interface IKMDStudicaSchoolInternships : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Gets the IActiveInternshipDepartmentsExternal.
        /// </summary>
        IActiveInternshipDepartmentsExternal ActiveInternshipDepartmentsExternal { get; }

        /// <summary>
        /// Gets the IBulkInternshipDepartmentsExternal.
        /// </summary>
        IBulkInternshipDepartmentsExternal BulkInternshipDepartmentsExternal { get; }

        /// <summary>
        /// Gets the IStudentInternshipsExternal.
        /// </summary>
        IStudentInternshipsExternal StudentInternshipsExternal { get; }

        /// <summary>
        /// Gets the IStudentInternshipsExternalV2.
        /// </summary>
        IStudentInternshipsExternalV2 StudentInternshipsExternalV2 { get; }

        /// <summary>
        /// Gets the IStudentsInternshipAbsenceExternal.
        /// </summary>
        IStudentsInternshipAbsenceExternal StudentsInternshipAbsenceExternal { get; }

        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PagedResponseInternshipDepartmentsExternalResponse>> PostWithHttpMessagesAsync(ActiveInternshipDepartmentsExternalRequest body = default(ActiveInternshipDepartmentsExternalRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='internshipDepartmentIds'>
        /// The ids of the internship departments to query for.
        /// </param>
        /// <param name='schoolCode'>
        /// String The school code for which to get data.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<InternshipDepartmentsExternalResponse>>> Post1WithHttpMessagesAsync(IList<System.Guid> internshipDepartmentIds, string schoolCode, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<StudentInternshipsExternalResponse>>> Post2WithHttpMessagesAsync(StudentInternshipsExternalRequest body = default(StudentInternshipsExternalRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<StudentInternshipsExternalV2Response>>> Post3WithHttpMessagesAsync(StudentInternshipsExternalV2Request body = default(StudentInternshipsExternalV2Request), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<StudentsInternshipAbsenceExternalResponse>>> Post4WithHttpMessagesAsync(StudentsInternshipAbsenceExternalRequest body = default(StudentsInternshipAbsenceExternalRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
