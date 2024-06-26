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
    /// RegisterAbsenceExternal operations.
    /// </summary>
    public partial interface IRegisterAbsenceExternal
    {
        /// <summary>
        /// RegisterAbsenceExternal_Post
        /// </summary>
        /// <param name='registerAbsenceExternalCommand'>
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
        Task<HttpOperationResponse> PostWithHttpMessagesAsync(RegisterAbsenceExternalCommand registerAbsenceExternalCommand = default(RegisterAbsenceExternalCommand), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
