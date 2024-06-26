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
    /// Extension methods for SchoolCoursesExternal.
    /// </summary>
    public static partial class SchoolCoursesExternalExtensions
    {
            /// <summary>
            /// SchoolCoursesExternal_Get
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
            /// <param name='periodFrom'>
            /// Format - date (as full-date in RFC3339). School courses start on or after
            /// this date
            /// </param>
            /// <param name='periodTo'>
            /// Format - date (as full-date in RFC3339). School courses must end on or
            /// before this date
            /// Property is nullable
            /// </param>
            /// <param name='includeDeletedSchoolCourses'>
            /// Should the response include deleted educational programmes
            /// </param>
            public static PagedResponseSchoolCourseExternalResponse Get(this ISchoolCoursesExternal operations, int pageNumber, int pageSize, bool inlineCount, string schoolCode, System.DateTime? periodFrom = default(System.DateTime?), System.DateTime? periodTo = default(System.DateTime?), bool? includeDeletedSchoolCourses = default(bool?))
            {
                return operations.GetAsync(pageNumber, pageSize, inlineCount, schoolCode, periodFrom, periodTo, includeDeletedSchoolCourses).GetAwaiter().GetResult();
            }

            /// <summary>
            /// SchoolCoursesExternal_Get
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
            /// <param name='periodFrom'>
            /// Format - date (as full-date in RFC3339). School courses start on or after
            /// this date
            /// </param>
            /// <param name='periodTo'>
            /// Format - date (as full-date in RFC3339). School courses must end on or
            /// before this date
            /// Property is nullable
            /// </param>
            /// <param name='includeDeletedSchoolCourses'>
            /// Should the response include deleted educational programmes
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResponseSchoolCourseExternalResponse> GetAsync(this ISchoolCoursesExternal operations, int pageNumber, int pageSize, bool inlineCount, string schoolCode, System.DateTime? periodFrom = default(System.DateTime?), System.DateTime? periodTo = default(System.DateTime?), bool? includeDeletedSchoolCourses = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(pageNumber, pageSize, inlineCount, schoolCode, periodFrom, periodTo, includeDeletedSchoolCourses, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
