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
    /// Extension methods for SchoolHoursPlansExternal.
    /// </summary>
    public static partial class SchoolHoursPlansExternalExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pageNumber'>
            /// The page number to return.
            /// </param>
            /// <param name='pageSize'>
            /// Number of objects per page.
            /// </param>
            /// <param name='inlineCount'>
            /// A flag indicating if include total number of items.
            /// </param>
            /// <param name='institutionNumber'>
            /// Institution number where plan belongs to.
            /// </param>
            public static PagedResponse1SchoolHoursPlansResponse Get(this ISchoolHoursPlansExternal operations, int pageNumber, int pageSize, bool inlineCount, string institutionNumber = default(string))
            {
                return operations.GetAsync(pageNumber, pageSize, inlineCount, institutionNumber).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pageNumber'>
            /// The page number to return.
            /// </param>
            /// <param name='pageSize'>
            /// Number of objects per page.
            /// </param>
            /// <param name='inlineCount'>
            /// A flag indicating if include total number of items.
            /// </param>
            /// <param name='institutionNumber'>
            /// Institution number where plan belongs to.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResponse1SchoolHoursPlansResponse> GetAsync(this ISchoolHoursPlansExternal operations, int pageNumber, int pageSize, bool inlineCount, string institutionNumber = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(pageNumber, pageSize, inlineCount, institutionNumber, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
