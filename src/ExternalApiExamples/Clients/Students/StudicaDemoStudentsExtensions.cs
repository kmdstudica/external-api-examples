// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.Students.Client
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for StudicaDemoStudents.
    /// </summary>
    public static partial class StudicaDemoStudentsExtensions
    {
            /// <summary>
            /// _ActiveStudentsExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='activeStudentsExternalRequest'>
            /// </param>
            public static PagedResponseStudentExternalResponse Post(this IStudicaDemoStudents operations, ActiveStudentsExternalRequest activeStudentsExternalRequest = default(ActiveStudentsExternalRequest))
            {
                return operations.PostAsync(activeStudentsExternalRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// _ActiveStudentsExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='activeStudentsExternalRequest'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResponseStudentExternalResponse> PostAsync(this IStudicaDemoStudents operations, ActiveStudentsExternalRequest activeStudentsExternalRequest = default(ActiveStudentsExternalRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(activeStudentsExternalRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// _StudentMarksExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='studentMarksExternalRequest'>
            /// </param>
            public static PagedResponseStudentMarksExternalResponse Post1(this IStudicaDemoStudents operations, StudentMarksExternalRequest studentMarksExternalRequest = default(StudentMarksExternalRequest))
            {
                return operations.Post1Async(studentMarksExternalRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// _StudentMarksExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='studentMarksExternalRequest'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResponseStudentMarksExternalResponse> Post1Async(this IStudicaDemoStudents operations, StudentMarksExternalRequest studentMarksExternalRequest = default(StudentMarksExternalRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Post1WithHttpMessagesAsync(studentMarksExternalRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}