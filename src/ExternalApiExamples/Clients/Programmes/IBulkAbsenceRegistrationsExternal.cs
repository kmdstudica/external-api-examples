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
    /// BulkAbsenceRegistrationsExternal operations.
    /// </summary>
    public partial interface IBulkAbsenceRegistrationsExternal
    {
        /// <param name='studentIds'>
        /// A list of student ids to get absence for.
        /// </param>
        /// <param name='dateFrom'>
        /// Beginning of the range for absence date.
        /// </param>
        /// <param name='dateTo'>
        /// End of the range for absence date.
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
        Task<HttpOperationResponse<IList<AbsenceRegistrationExternalResponse>>> GetWithHttpMessagesAsync(IList<System.Guid> studentIds, System.DateTime dateFrom, System.DateTime dateTo, string schoolCode, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
