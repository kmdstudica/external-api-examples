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
    /// Extension methods for KMDStudicaSchoolInternships.
    /// </summary>
    public static partial class KMDStudicaSchoolInternshipsExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xSelectedSchoolCode'>
            /// Selected school code, used when multiple impersonation permissions are
            /// available on the token
            /// </param>
            /// <param name='body'>
            /// </param>
            public static IList<StudentInternshipsExternalResponse> Post(this IKMDStudicaSchoolInternships operations, string xSelectedSchoolCode = default(string), StudentInternshipsExternalRequest body = default(StudentInternshipsExternalRequest))
            {
                return operations.PostAsync(xSelectedSchoolCode, body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xSelectedSchoolCode'>
            /// Selected school code, used when multiple impersonation permissions are
            /// available on the token
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<StudentInternshipsExternalResponse>> PostAsync(this IKMDStudicaSchoolInternships operations, string xSelectedSchoolCode = default(string), StudentInternshipsExternalRequest body = default(StudentInternshipsExternalRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(xSelectedSchoolCode, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xSelectedSchoolCode'>
            /// Selected school code, used when multiple impersonation permissions are
            /// available on the token
            /// </param>
            /// <param name='body'>
            /// </param>
            public static IList<StudentsInternshipAbsenceExternalResponse> Post1(this IKMDStudicaSchoolInternships operations, string xSelectedSchoolCode = default(string), StudentsInternshipAbsenceExternalRequest body = default(StudentsInternshipAbsenceExternalRequest))
            {
                return operations.Post1Async(xSelectedSchoolCode, body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='xSelectedSchoolCode'>
            /// Selected school code, used when multiple impersonation permissions are
            /// available on the token
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<StudentsInternshipAbsenceExternalResponse>> Post1Async(this IKMDStudicaSchoolInternships operations, string xSelectedSchoolCode = default(string), StudentsInternshipAbsenceExternalRequest body = default(StudentsInternshipAbsenceExternalRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Post1WithHttpMessagesAsync(xSelectedSchoolCode, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
