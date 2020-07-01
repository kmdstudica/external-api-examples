// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.Programmes.Client
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AggregateExistsExternal.
    /// </summary>
    public static partial class AggregateExistsExternalExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='schoolCode'>
            /// </param>
            /// <param name='tableName'>
            /// </param>
            /// <param name='idColumn'>
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='filter'>
            /// Possible values include: 'None', 'SchoolCode', 'InstitutionNumber'
            /// </param>
            public static bool? Get(this IAggregateExistsExternal operations, string schoolCode, string tableName, string idColumn, System.Guid id, string filter)
            {
                return operations.GetAsync(schoolCode, tableName, idColumn, id, filter).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='schoolCode'>
            /// </param>
            /// <param name='tableName'>
            /// </param>
            /// <param name='idColumn'>
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='filter'>
            /// Possible values include: 'None', 'SchoolCode', 'InstitutionNumber'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<bool?> GetAsync(this IAggregateExistsExternal operations, string schoolCode, string tableName, string idColumn, System.Guid id, string filter, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(schoolCode, tableName, idColumn, id, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
