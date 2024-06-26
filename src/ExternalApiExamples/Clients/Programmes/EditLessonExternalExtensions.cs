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
    /// Extension methods for EditLessonExternal.
    /// </summary>
    public static partial class EditLessonExternalExtensions
    {
            /// <summary>
            /// EditLessonExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='editLessonExternalCommand'>
            /// </param>
            public static void Post(this IEditLessonExternal operations, EditLessonExternalCommand editLessonExternalCommand = default(EditLessonExternalCommand))
            {
                operations.PostAsync(editLessonExternalCommand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// EditLessonExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='editLessonExternalCommand'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PostAsync(this IEditLessonExternal operations, EditLessonExternalCommand editLessonExternalCommand = default(EditLessonExternalCommand), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PostWithHttpMessagesAsync(editLessonExternalCommand, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
