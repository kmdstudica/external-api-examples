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
    /// SessionsExternal operations.
    /// </summary>
    public partial interface ISessionsExternal
    {
        /// <param name='pageNumber'>
        /// The number of the page to return (1 is the first page).
        /// </param>
        /// <param name='pageSize'>
        /// Number of objects per page.
        /// </param>
        /// <param name='inlineCount'>
        /// A flag indicating if total number of items should be included.
        /// </param>
        /// <param name='schoolCode'>
        /// The school code for which to get data.
        /// </param>
        /// <param name='groupIds'>
        /// If specified, returns sessions which have at least one of the
        /// specific groups.
        /// </param>
        /// <param name='teacherIds'>
        /// If specified, returns sessions which have at least one of the
        /// specific teachers.
        /// </param>
        /// <param name='roomIds'>
        /// If specified, returns sessions which have at least one of the
        /// specific rooms.
        /// </param>
        /// <param name='dateFrom'>
        /// If specified, returns sessions which are planned on a date no
        /// earlier than this.
        /// </param>
        /// <param name='dateTo'>
        /// If specified, returns sessions which are planned on a date no later
        /// than this.
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
        Task<HttpOperationResponse<PagedResponseSessionDto>> GetWithHttpMessagesAsync(int pageNumber, int pageSize, bool inlineCount, string schoolCode, IList<System.Guid> groupIds = default(IList<System.Guid>), IList<System.Guid> teacherIds = default(IList<System.Guid>), IList<System.Guid> roomIds = default(IList<System.Guid>), System.DateTime? dateFrom = default(System.DateTime?), System.DateTime? dateTo = default(System.DateTime?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
