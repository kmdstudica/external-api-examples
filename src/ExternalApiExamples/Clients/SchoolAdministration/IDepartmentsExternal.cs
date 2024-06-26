// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.SchoolAdministration.Client
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// DepartmentsExternal operations.
    /// </summary>
    public partial interface IDepartmentsExternal
    {
        /// <summary>
        /// DepartmentsExternal_Get
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
        /// <param name='validFrom'>
        /// Format - date (as full-date in RFC3339). Beginning date of being
        /// valid.
        /// </param>
        /// <param name='validTo'>
        /// Format - date (as full-date in RFC3339). End date of being valid.
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
        Task<HttpOperationResponse<PagedResponseDepartmentsExternalResponse>> GetWithHttpMessagesAsync(int pageNumber, int pageSize, bool inlineCount, string schoolCode, System.DateTime? validFrom = default(System.DateTime?), System.DateTime? validTo = default(System.DateTime?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
