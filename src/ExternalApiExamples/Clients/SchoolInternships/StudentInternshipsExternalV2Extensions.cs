// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.SchoolInternships.Client
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for StudentInternshipsExternalV2.
    /// </summary>
    public static partial class StudentInternshipsExternalV2Extensions
    {
            /// <summary>
            /// StudentInternshipsExternalV2_Get
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='schoolCode'>
            /// The school code for which to get data.
            /// </param>
            /// <param name='periodFrom'>
            /// Format - date (as full-date in RFC3339). Get all students school
            /// internships starting on or after this date
            /// </param>
            /// <param name='periodTo'>
            /// Format - date (as full-date in RFC3339). Get all students school
            /// internships ending on or before this date
            /// </param>
            public static IList<StudentInternshipsExternalV2Response> Get(this IStudentInternshipsExternalV2 operations, string schoolCode, System.DateTime? periodFrom = default(System.DateTime?), System.DateTime? periodTo = default(System.DateTime?))
            {
                return operations.GetAsync(schoolCode, periodFrom, periodTo).GetAwaiter().GetResult();
            }

            /// <summary>
            /// StudentInternshipsExternalV2_Get
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='schoolCode'>
            /// The school code for which to get data.
            /// </param>
            /// <param name='periodFrom'>
            /// Format - date (as full-date in RFC3339). Get all students school
            /// internships starting on or after this date
            /// </param>
            /// <param name='periodTo'>
            /// Format - date (as full-date in RFC3339). Get all students school
            /// internships ending on or before this date
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<StudentInternshipsExternalV2Response>> GetAsync(this IStudentInternshipsExternalV2 operations, string schoolCode, System.DateTime? periodFrom = default(System.DateTime?), System.DateTime? periodTo = default(System.DateTime?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(schoolCode, periodFrom, periodTo, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
