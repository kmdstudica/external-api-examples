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
    /// Extension methods for BulkAreasOfResponsibilityExternal.
    /// </summary>
    public static partial class BulkAreasOfResponsibilityExternalExtensions
    {
            /// <summary>
            /// BulkAreasOfResponsibilityExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='areaOfResponsibilityIds'>
            /// Areas of responsibility identifiers for bulk query.
            /// </param>
            /// <param name='schoolCode'>
            /// String The school code for which to get data.
            /// </param>
            public static IList<AreaOfResponsibilityExternalResponse> Post(this IBulkAreasOfResponsibilityExternal operations, IList<System.Guid> areaOfResponsibilityIds, string schoolCode)
            {
                return operations.PostAsync(areaOfResponsibilityIds, schoolCode).GetAwaiter().GetResult();
            }

            /// <summary>
            /// BulkAreasOfResponsibilityExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='areaOfResponsibilityIds'>
            /// Areas of responsibility identifiers for bulk query.
            /// </param>
            /// <param name='schoolCode'>
            /// String The school code for which to get data.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<AreaOfResponsibilityExternalResponse>> PostAsync(this IBulkAreasOfResponsibilityExternal operations, IList<System.Guid> areaOfResponsibilityIds, string schoolCode, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(areaOfResponsibilityIds, schoolCode, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
