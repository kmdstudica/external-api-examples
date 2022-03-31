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
    /// Extension methods for DeleteLessonsExternal.
    /// </summary>
    public static partial class DeleteLessonsExternalExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static void Post(this IDeleteLessonsExternal operations, DeleteLessonsExternalCommand body = default(DeleteLessonsExternalCommand))
            {
                operations.PostAsync(body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PostAsync(this IDeleteLessonsExternal operations, DeleteLessonsExternalCommand body = default(DeleteLessonsExternalCommand), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PostWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
