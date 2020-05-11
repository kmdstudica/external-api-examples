// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.Programmes.Client
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BulkEducationalProgrammesExternal.
    /// </summary>
    public static partial class BulkEducationalProgrammesExternalExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='educationalProgrammeIds'>
            /// Educational programme identifiers for bulk query.
            /// </param>
            /// <param name='schoolCode'>
            /// The school code for which to get data.
            /// </param>
            public static IList<EducationalProgrammeExternalResponse> Post(this IBulkEducationalProgrammesExternal operations, IList<System.Guid> educationalProgrammeIds, string schoolCode)
            {
                return operations.PostAsync(educationalProgrammeIds, schoolCode).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='educationalProgrammeIds'>
            /// Educational programme identifiers for bulk query.
            /// </param>
            /// <param name='schoolCode'>
            /// The school code for which to get data.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<EducationalProgrammeExternalResponse>> PostAsync(this IBulkEducationalProgrammesExternal operations, IList<System.Guid> educationalProgrammeIds, string schoolCode, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(educationalProgrammeIds, schoolCode, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}