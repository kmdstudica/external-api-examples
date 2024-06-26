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
    /// Extension methods for SubjectCoursesExternal.
    /// </summary>
    public static partial class SubjectCoursesExternalExtensions
    {
            /// <summary>
            /// SubjectCoursesExternal_Get
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
            /// <param name='startDateFrom'>
            /// Format - date (as full-date in RFC3339). Beginning of the range for start
            /// date subject courses.
            /// </param>
            /// <param name='startDateTo'>
            /// Format - date (as full-date in RFC3339). End of the range for start date
            /// subject courses.
            /// </param>
            /// <param name='lmsIndicator'>
            /// Is the entity to be created in the LMS.
            /// If not specified, then the value of the LMS indicator is disregarded in the
            /// filtering.
            /// </param>
            /// <param name='includeDeletedSubjectCourses'>
            /// Should the response include deleted subject courses
            /// </param>
            /// <param name='onlyDataInsertedOrUpdatedOnOrAfter'>
            /// Format - date-time (as date-time in RFC3339). Only get data inserted or
            /// updated on or after the specified date
            /// </param>
            public static PagedResponseSubjectCourseExternalResponse Get(this ISubjectCoursesExternal operations, int pageNumber, int pageSize, bool inlineCount, string schoolCode, System.DateTime? startDateFrom = default(System.DateTime?), System.DateTime? startDateTo = default(System.DateTime?), bool? lmsIndicator = default(bool?), bool? includeDeletedSubjectCourses = default(bool?), System.DateTime? onlyDataInsertedOrUpdatedOnOrAfter = default(System.DateTime?))
            {
                return operations.GetAsync(pageNumber, pageSize, inlineCount, schoolCode, startDateFrom, startDateTo, lmsIndicator, includeDeletedSubjectCourses, onlyDataInsertedOrUpdatedOnOrAfter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// SubjectCoursesExternal_Get
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
            /// <param name='startDateFrom'>
            /// Format - date (as full-date in RFC3339). Beginning of the range for start
            /// date subject courses.
            /// </param>
            /// <param name='startDateTo'>
            /// Format - date (as full-date in RFC3339). End of the range for start date
            /// subject courses.
            /// </param>
            /// <param name='lmsIndicator'>
            /// Is the entity to be created in the LMS.
            /// If not specified, then the value of the LMS indicator is disregarded in the
            /// filtering.
            /// </param>
            /// <param name='includeDeletedSubjectCourses'>
            /// Should the response include deleted subject courses
            /// </param>
            /// <param name='onlyDataInsertedOrUpdatedOnOrAfter'>
            /// Format - date-time (as date-time in RFC3339). Only get data inserted or
            /// updated on or after the specified date
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResponseSubjectCourseExternalResponse> GetAsync(this ISubjectCoursesExternal operations, int pageNumber, int pageSize, bool inlineCount, string schoolCode, System.DateTime? startDateFrom = default(System.DateTime?), System.DateTime? startDateTo = default(System.DateTime?), bool? lmsIndicator = default(bool?), bool? includeDeletedSubjectCourses = default(bool?), System.DateTime? onlyDataInsertedOrUpdatedOnOrAfter = default(System.DateTime?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(pageNumber, pageSize, inlineCount, schoolCode, startDateFrom, startDateTo, lmsIndicator, includeDeletedSubjectCourses, onlyDataInsertedOrUpdatedOnOrAfter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
