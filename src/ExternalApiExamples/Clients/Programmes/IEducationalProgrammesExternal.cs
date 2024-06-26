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
        /// <summary>
        /// EducationalProgrammesExternal_Get
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
        /// <param name='startDateFrom'>
        /// Format - date (as full-date in RFC3339). Beginning of the range for
        /// start date of the educational programmes.
        /// </param>
        /// <param name='startDateTo'>
        /// Format - date (as full-date in RFC3339). End of the range for start
        /// date of the educational programmes.
        /// </param>
        /// <param name='areaOfResponsibilityId'>
        /// Format - uuid. Option for also querying educational programmes by
        /// area of responsibility in addition to dates
        /// </param>
        /// <param name='includeDeletedProgrammes'>
        /// Should the response include deleted educational programmes
        /// </param>
        /// <param name='onlyDataInsertedOrUpdatedOnOrAfter'>
        /// Format - date-time (as date-time in RFC3339). Only get data
        /// inserted or updated on or after the specified date
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
        Task<HttpOperationResponse<PagedResponseEducationalProgrammeExternalResponse>> GetWithHttpMessagesAsync(int pageNumber, int pageSize, bool inlineCount, string schoolCode, System.DateTime? startDateFrom = default(System.DateTime?), System.DateTime? startDateTo = default(System.DateTime?), System.Guid? areaOfResponsibilityId = default(System.Guid?), bool? includeDeletedProgrammes = default(bool?), System.DateTime? onlyDataInsertedOrUpdatedOnOrAfter = default(System.DateTime?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
