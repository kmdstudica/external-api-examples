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
    /// Extension methods for ActiveBridgingCoursesExternal.
    /// </summary>
    public static partial class ActiveBridgingCoursesExternalExtensions
    {
            /// <summary>
            /// ActiveBridgingCoursesExternal_Get
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bridgingCoursesActiveOnOrAfterDate'>
            /// Format - date (as full-date in RFC3339). Bridging courses must be active on
            /// the date or after this date
            /// This parameter is required
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
            /// <param name='onlyDataInsertedOrUpdatedOnOrAfter'>
            /// Format - date-time (as date-time in RFC3339). Only get data inserted or
            /// updated on or after the specified date
            /// </param>
            public static PagedResponseBridgingCoursesExternalResponse Get(this IActiveBridgingCoursesExternal operations, System.DateTime bridgingCoursesActiveOnOrAfterDate, int pageNumber, int pageSize, bool inlineCount, string schoolCode, System.DateTime? onlyDataInsertedOrUpdatedOnOrAfter = default(System.DateTime?))
            {
                return operations.GetAsync(bridgingCoursesActiveOnOrAfterDate, pageNumber, pageSize, inlineCount, schoolCode, onlyDataInsertedOrUpdatedOnOrAfter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// ActiveBridgingCoursesExternal_Get
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bridgingCoursesActiveOnOrAfterDate'>
            /// Format - date (as full-date in RFC3339). Bridging courses must be active on
            /// the date or after this date
            /// This parameter is required
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
            /// <param name='onlyDataInsertedOrUpdatedOnOrAfter'>
            /// Format - date-time (as date-time in RFC3339). Only get data inserted or
            /// updated on or after the specified date
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResponseBridgingCoursesExternalResponse> GetAsync(this IActiveBridgingCoursesExternal operations, System.DateTime bridgingCoursesActiveOnOrAfterDate, int pageNumber, int pageSize, bool inlineCount, string schoolCode, System.DateTime? onlyDataInsertedOrUpdatedOnOrAfter = default(System.DateTime?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(bridgingCoursesActiveOnOrAfterDate, pageNumber, pageSize, inlineCount, schoolCode, onlyDataInsertedOrUpdatedOnOrAfter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
