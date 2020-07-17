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
    /// Extension methods for KMDStudicaProgrammes.
    /// </summary>
    public static partial class KMDStudicaProgrammesExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static PagedResponseAbsenceRegistrationExternalResponse Post(this IKMDStudicaProgrammes operations, AbsenceRegistrationsExternalRequest body = default(AbsenceRegistrationsExternalRequest))
            {
                return operations.PostAsync(body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResponseAbsenceRegistrationExternalResponse> PostAsync(this IKMDStudicaProgrammes operations, AbsenceRegistrationsExternalRequest body = default(AbsenceRegistrationsExternalRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static PagedResponseEducationalProgrammeExternalResponse Post1(this IKMDStudicaProgrammes operations, EducationalProgrammesExternalRequest body = default(EducationalProgrammesExternalRequest))
            {
                return operations.Post1Async(body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResponseEducationalProgrammeExternalResponse> Post1Async(this IKMDStudicaProgrammes operations, EducationalProgrammesExternalRequest body = default(EducationalProgrammesExternalRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Post1WithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static PagedResponseLessonExternalResponse Post2(this IKMDStudicaProgrammes operations, LessonsExternalRequest body = default(LessonsExternalRequest))
            {
                return operations.Post2Async(body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResponseLessonExternalResponse> Post2Async(this IKMDStudicaProgrammes operations, LessonsExternalRequest body = default(LessonsExternalRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Post2WithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static PagedResponseSubjectCourseExternalResponse Post3(this IKMDStudicaProgrammes operations, SubjectCoursesExternalRequest body = default(SubjectCoursesExternalRequest))
            {
                return operations.Post3Async(body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResponseSubjectCourseExternalResponse> Post3Async(this IKMDStudicaProgrammes operations, SubjectCoursesExternalRequest body = default(SubjectCoursesExternalRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Post3WithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static PagedResponseUnscheduledLessonExternalResponse Post4(this IKMDStudicaProgrammes operations, LessonsExternalRequest body = default(LessonsExternalRequest))
            {
                return operations.Post4Async(body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResponseUnscheduledLessonExternalResponse> Post4Async(this IKMDStudicaProgrammes operations, LessonsExternalRequest body = default(LessonsExternalRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Post4WithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
