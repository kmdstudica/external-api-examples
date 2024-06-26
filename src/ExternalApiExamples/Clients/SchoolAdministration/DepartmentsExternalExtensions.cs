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
    /// Extension methods for DepartmentsExternal.
    /// </summary>
    public static partial class DepartmentsExternalExtensions
    {
            /// <summary>
            /// DepartmentsExternal_Get
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pageNumber'>
            /// Format - int32. The number of the page to return (1 is the first page).
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
            /// Format - date (as full-date in RFC3339). Beginning date of being valid.
            /// </param>
            /// <param name='validTo'>
            /// Format - date (as full-date in RFC3339). End date of being valid.
            /// </param>
            public static PagedResponseDepartmentsExternalResponse Get(this IDepartmentsExternal operations, int pageNumber, int pageSize, bool inlineCount, string schoolCode, System.DateTime? validFrom = default(System.DateTime?), System.DateTime? validTo = default(System.DateTime?))
            {
                return operations.GetAsync(pageNumber, pageSize, inlineCount, schoolCode, validFrom, validTo).GetAwaiter().GetResult();
            }

            /// <summary>
            /// DepartmentsExternal_Get
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pageNumber'>
            /// Format - int32. The number of the page to return (1 is the first page).
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
            /// Format - date (as full-date in RFC3339). Beginning date of being valid.
            /// </param>
            /// <param name='validTo'>
            /// Format - date (as full-date in RFC3339). End date of being valid.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResponseDepartmentsExternalResponse> GetAsync(this IDepartmentsExternal operations, int pageNumber, int pageSize, bool inlineCount, string schoolCode, System.DateTime? validFrom = default(System.DateTime?), System.DateTime? validTo = default(System.DateTime?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(pageNumber, pageSize, inlineCount, schoolCode, validFrom, validTo, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
