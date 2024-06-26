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
    /// Extension methods for StudentSchoolCoursesExternal.
    /// </summary>
    public static partial class StudentSchoolCoursesExternalExtensions
    {
            /// <summary>
            /// StudentSchoolCoursesExternal_Get
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='studentIds'>
            /// Student ids for bulk query. Must contain 1 to 1000 elements
            /// </param>
            /// <param name='schoolCode'>
            /// The school code for which to get data.
            /// </param>
            /// <param name='periodFrom'>
            /// Format - date (as full-date in RFC3339). Beginning of the range for start
            /// date of the students' school courses.
            /// </param>
            /// <param name='periodTo'>
            /// Format - date (as full-date in RFC3339). End of the range for start date of
            /// the students' school courses.
            /// </param>
            public static IList<StudentSchoolCoursesExternalResponse> Get(this IStudentSchoolCoursesExternal operations, IList<System.Guid> studentIds, string schoolCode, System.DateTime? periodFrom = default(System.DateTime?), System.DateTime? periodTo = default(System.DateTime?))
            {
                return operations.GetAsync(studentIds, schoolCode, periodFrom, periodTo).GetAwaiter().GetResult();
            }

            /// <summary>
            /// StudentSchoolCoursesExternal_Get
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='studentIds'>
            /// Student ids for bulk query. Must contain 1 to 1000 elements
            /// </param>
            /// <param name='schoolCode'>
            /// The school code for which to get data.
            /// </param>
            /// <param name='periodFrom'>
            /// Format - date (as full-date in RFC3339). Beginning of the range for start
            /// date of the students' school courses.
            /// </param>
            /// <param name='periodTo'>
            /// Format - date (as full-date in RFC3339). End of the range for start date of
            /// the students' school courses.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<StudentSchoolCoursesExternalResponse>> GetAsync(this IStudentSchoolCoursesExternal operations, IList<System.Guid> studentIds, string schoolCode, System.DateTime? periodFrom = default(System.DateTime?), System.DateTime? periodTo = default(System.DateTime?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(studentIds, schoolCode, periodFrom, periodTo, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
