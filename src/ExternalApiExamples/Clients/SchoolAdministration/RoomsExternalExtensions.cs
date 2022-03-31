// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.SchoolAdministration.Client
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RoomsExternal.
    /// </summary>
    public static partial class RoomsExternalExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
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
            /// <param name='schoolCode'>
            /// The school code for which to get data.
            /// </param>
            /// <param name='departmentId'>
            /// Department identifiers for querying only rooms in a specific department
            /// </param>
            public static PagedResponseRoomExternalResponse Get(this IRoomsExternal operations, int pageNumber, int pageSize, bool inlineCount, string schoolCode, System.Guid? departmentId = default(System.Guid?))
            {
                return operations.GetAsync(pageNumber, pageSize, inlineCount, schoolCode, departmentId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
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
            /// <param name='schoolCode'>
            /// The school code for which to get data.
            /// </param>
            /// <param name='departmentId'>
            /// Department identifiers for querying only rooms in a specific department
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResponseRoomExternalResponse> GetAsync(this IRoomsExternal operations, int pageNumber, int pageSize, bool inlineCount, string schoolCode, System.Guid? departmentId = default(System.Guid?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(pageNumber, pageSize, inlineCount, schoolCode, departmentId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
