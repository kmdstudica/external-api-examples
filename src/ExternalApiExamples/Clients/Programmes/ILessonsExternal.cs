// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.Programmes.Client
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// LessonsExternal operations.
    /// </summary>
    public partial interface ILessonsExternal
    {
        /// <summary>
        /// LessonsExternal_Get
        /// </summary>
        /// <param name='pageNumber'>
        /// Format - int32. The number of the page to return (1 is the first
        /// page).
        /// </param>
        /// <param name='pageSize'>
        /// Format - int32. Number of objects per page.
        /// </param>
        /// <param name='inlineCount'>
        /// A flag indicating if total number of items should be included.
        /// </param>
        /// <param name='schoolCode'>
        /// The school code for which to get data.
        /// </param>
        /// <param name='departmentId'>
        /// Format - uuid. Department where the lesson is conducted.
        /// </param>
        /// <param name='dateFrom'>
        /// Format - date (as full-date in RFC3339). Beginning of range for
        /// lesson date.
        /// </param>
        /// <param name='dateTo'>
        /// Format - date (as full-date in RFC3339). End of range for lesson
        /// date.
        /// </param>
        /// <param name='hasExternalId'>
        /// Flag indicating if lesson contains external id.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<PagedResponseLessonExternalResponse>> GetWithHttpMessagesAsync(int pageNumber, int pageSize, bool inlineCount, string schoolCode, System.Guid? departmentId = default(System.Guid?), System.DateTime? dateFrom = default(System.DateTime?), System.DateTime? dateTo = default(System.DateTime?), bool? hasExternalId = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
