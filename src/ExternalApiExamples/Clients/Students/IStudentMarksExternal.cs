// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.Students.Client
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// StudentMarksExternal operations.
    /// </summary>
    public partial interface IStudentMarksExternal
    {
        /// <summary>
        /// StudentMarksExternal_Get
        /// </summary>
        /// <param name='studentIds'>
        /// A list of students to get marks for
        /// </param>
        /// <param name='onlyIncludeMarksForExamPaper'>
        /// Flag to indicate if service should only return marks that should be
        /// included on exam paper
        /// </param>
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
        Task<HttpOperationResponse<PagedResponseStudentMarksExternalResponse>> GetWithHttpMessagesAsync(IList<System.Guid> studentIds, bool onlyIncludeMarksForExamPaper, int pageNumber, int pageSize, bool inlineCount, string schoolCode, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
