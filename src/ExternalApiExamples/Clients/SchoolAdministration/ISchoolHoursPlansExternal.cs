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
    /// SchoolHoursPlansExternal operations.
    /// </summary>
    public partial interface ISchoolHoursPlansExternal
    {
        /// <param name='pageNumber'>
        /// The page number to return.
        /// </param>
        /// <param name='pageSize'>
        /// Number of objects per page.
        /// </param>
        /// <param name='inlineCount'>
        /// A flag indicating if include total number of items.
        /// </param>
        /// <param name='institutionNumber'>
        /// Institution number where plan belongs to.
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
        Task<HttpOperationResponse<PagedResponse1SchoolHoursPlansResponse>> GetWithHttpMessagesAsync(int pageNumber, int pageSize, bool inlineCount, string institutionNumber = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
