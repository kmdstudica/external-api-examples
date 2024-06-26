// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.SchoolAdministration.Client
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BulkDepartmentsExternal.
    /// </summary>
    public static partial class BulkDepartmentsExternalExtensions
    {
            /// <summary>
            /// BulkDepartmentsExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='departmentIds'>
            /// Department identifiers for bulk query.
            /// </param>
            /// <param name='schoolCode'>
            /// String The school code for which to get data.
            /// </param>
            public static IList<DepartmentsExternalResponse> Post(this IBulkDepartmentsExternal operations, IList<System.Guid> departmentIds, string schoolCode)
            {
                return operations.PostAsync(departmentIds, schoolCode).GetAwaiter().GetResult();
            }

            /// <summary>
            /// BulkDepartmentsExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='departmentIds'>
            /// Department identifiers for bulk query.
            /// </param>
            /// <param name='schoolCode'>
            /// String The school code for which to get data.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<DepartmentsExternalResponse>> PostAsync(this IBulkDepartmentsExternal operations, IList<System.Guid> departmentIds, string schoolCode, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(departmentIds, schoolCode, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
