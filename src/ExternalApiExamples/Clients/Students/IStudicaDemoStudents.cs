// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.Students.Client
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
    public partial interface IStudicaDemoStudents : System.IDisposable
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
        /// Gets the IActiveStudentsExternal.
        /// </summary>
        IActiveStudentsExternal ActiveStudentsExternal { get; }

        /// <summary>
        /// Gets the IBulkStudentsExternal.
        /// </summary>
        IBulkStudentsExternal BulkStudentsExternal { get; }

        /// <summary>
        /// Gets the IStudentMarksExternal.
        /// </summary>
        IStudentMarksExternal StudentMarksExternal { get; }

        /// <summary>
        /// Gets the IUpdateContactAndAccountInfoExternal.
        /// </summary>
        IUpdateContactAndAccountInfoExternal UpdateContactAndAccountInfoExternal { get; }

        /// <summary>
        /// _ActiveStudentsExternal_Post
        /// </summary>
        /// <param name='activeStudentsExternalRequest'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PagedResponseStudentExternalResponse>> PostWithHttpMessagesAsync(ActiveStudentsExternalRequest activeStudentsExternalRequest = default(ActiveStudentsExternalRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// _StudentMarksExternal_Post
        /// </summary>
        /// <param name='studentMarksExternalRequest'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PagedResponseStudentMarksExternalResponse>> Post1WithHttpMessagesAsync(StudentMarksExternalRequest studentMarksExternalRequest = default(StudentMarksExternalRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
