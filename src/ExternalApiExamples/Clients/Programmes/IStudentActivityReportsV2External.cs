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
    /// StudentActivityReportsV2External operations.
    /// </summary>
    public partial interface IStudentActivityReportsV2External
    {
        /// <param name='periodFrom'>
        /// Includes reports for periods with a transmission period start date
        /// no earlier than {PeriodFrom}
        /// </param>
        /// <param name='periodTo'>
        /// Includes reports for periods with a transmission period start date
        /// no later than {PeriodFromTo}
        /// </param>
        /// <param name='schoolCode'>
        /// The school code for which to get data.
        /// </param>
        /// <param name='xSelectedSchoolCode'>
        /// Selected school code, used when multiple impersonation permissions
        /// are available on the token
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
        Task<HttpOperationResponse<IList<ActivityGroup2Dto>>> GetWithHttpMessagesAsync(System.DateTime periodFrom, System.DateTime periodTo, string schoolCode, string xSelectedSchoolCode = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
