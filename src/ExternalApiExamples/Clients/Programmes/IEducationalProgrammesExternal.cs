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
    /// EducationalProgrammesExternal operations.
    /// </summary>
    public partial interface IEducationalProgrammesExternal
    {
        /// <param name='startDateFrom'>
        /// Beginning of the range for start date of the educational
        /// programmes.
        /// </param>
        /// <param name='startDateTo'>
        /// End of the range for start date of the educational programmes.
        /// </param>
        /// <param name='schoolCode'>
        /// The school code for which to get data.
        /// </param>
        /// <param name='pageNumber'>
        /// The number of the page to return (1 is the first page).
        /// </param>
        /// <param name='pageSize'>
        /// Number of objects per page.
        /// </param>
        /// <param name='inlineCount'>
        /// A flag indicating if total number of items should be included.
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
        Task<HttpOperationResponse<PagedResponseEducationalProgrammeExternalResponse>> GetWithHttpMessagesAsync(System.DateTime startDateFrom, System.DateTime startDateTo, string schoolCode, int pageNumber, int pageSize, bool inlineCount, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
