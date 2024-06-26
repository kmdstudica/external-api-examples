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
    /// StudentInternshipExternal operations.
    /// </summary>
    public partial interface IStudentInternshipExternal
    {
        /// <summary>
        /// StudentInternshipExternal_Get
        /// </summary>
        /// <param name='schoolCode'>
        /// The school code for which to get data.
        /// </param>
        /// <param name='periodFrom'>
        /// Format - date (as full-date in RFC3339). Beginning of the range for
        /// start date of the students' internships.
        /// </param>
        /// <param name='periodTo'>
        /// Format - date (as full-date in RFC3339). End of the range for start
        /// date of the students' internships.
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
        Task<HttpOperationResponse<IList<StudentInternshipExternalResponse>>> GetWithHttpMessagesAsync(string schoolCode, System.DateTime? periodFrom = default(System.DateTime?), System.DateTime? periodTo = default(System.DateTime?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
